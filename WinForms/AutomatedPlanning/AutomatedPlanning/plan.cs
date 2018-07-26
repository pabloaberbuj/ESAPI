using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace AutomatedPlanning
{
    class Plan
    {
        public static string optimizarIMRT(ExternalPlanSetup plan)
        {
            var watch = Stopwatch.StartNew();
            plan.SetCalculationModel(CalculationType.PhotonIMRTOptimization, Configuracion.OptimizationAlgorithm);
            var opt = new OptimizationOptionsIMRT(2500, OptimizationOption.RestartOptimization, OptimizationConvergenceOption.TerminateIfConverged, Configuracion.MlcId);
            var res = plan.Optimize(opt);
            if (!res.Success)
            {
                return string.Format("Falló la optimización para el plan '{0}'", plan.Id);
            }
            else
            {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                return string.Format("Finalizó la optimización para el plan '{0}'. Demoró " + elapsedMs.ToString() + "ms", plan.Id);
            }
        }

        public static string calcularMovimientoLaminas(ExternalPlanSetup plan)
        {
            var watch = Stopwatch.StartNew();
            plan.SetCalculationModel(CalculationType.PhotonVolumeDose, Configuracion.DoseCalculationAlgorithm);
            plan.SetCalculationModel(CalculationType.PhotonLeafMotions, Configuracion.LeafMotionCalculator);
            var res = plan.CalculateLeafMotions();
            if (!res.Success)
            {
                return string.Format("Falló el cálculo de movimiento de láminas para el plan '{0}'. Output:\n{1}", plan.Id, res);
            }
            else
            {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                return string.Format("Finalizó el cálculo de movimiento de láminas para el plan '{0}'. Demoró " + elapsedMs.ToString() + "ms", plan.Id);
            }
        }

        public static string calcularDosis(ExternalPlanSetup plan)
        {
            var watch = Stopwatch.StartNew();
            plan.SetCalculationModel(CalculationType.PhotonVolumeDose, Configuracion.DoseCalculationAlgorithm);
            var res = plan.CalculateDose();
            if (!res.Success)
            {
                return string.Format("Falló el cálculo de dosis para el plan '{0}'. Output:\n{1}", plan.Id, res);
                //throw new Exception(message);
            }
            else
            {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                return string.Format("Finalizó el cálculo de dosis para el plan '{0}'. Demoró " + elapsedMs.ToString() + "ms", plan.Id);
            }
        }
    }
}

