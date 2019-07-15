using System;
using System.Collections.Generic;
using System.Linq;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public static class DVHDataExtensions_ESAPIX
    {


        /// <summary>
        ///     Gets the volume that recieves the input dose
        /// </summary>
        /// <param name="dvh">the dose volume histogram for this structure</param>
        /// <param name="dv">the dose value to sample the curve</param>
        /// <returns>the volume in the same units as the DVH point array</returns>
        public static double GetVolumeAtDose(this DVHPoint[] dvh, DoseValue dv)
        {
            var curve = dvh.Select(d => new { Dose = d.DoseValue.Dose, d.Volume, d.VolumeUnit });
            var maxDose = curve.Max(d => d.Dose);
            var minDose = curve.Min(d => d.Dose);

            //If the max dose is less than the queried dose, then there is no volume at the queried dose (out of range)
            //If the min dose is greater than the queried dose, then 100% of the volume is at the queried dose
            if (dv.Dose >= maxDose) return 0;
            if (dv.Dose < minDose) { return dvh.Max(d => d.Volume); }

            var higherPoint = curve.First(p => p.Dose > dv.Dose);
            var lowerPoint = curve.Last(p => p.Dose <= dv.Dose);
            var volumeAtPoint = interpolar1D(higherPoint.Dose, lowerPoint.Dose, higherPoint.Volume, lowerPoint.Volume,dv.Dose);
            return volumeAtPoint;
        }

        public static DoseValue GetDoseAtVolume(this DVHPoint[] dvh, double volume)
        {
            var minVol = dvh.Min(d => d.Volume);
            var maxVol = dvh.Max(d => d.Volume);

            //Check for max point dose scenario
            if (volume <= minVol) return dvh.MaxDose();

            //Check dose to total volume scenario (min dose)
            if (volume == maxVol)
                return dvh.MinDose();

            //Overvolume scenario, undefined
            if (volume > maxVol)
                return DoseValue.UndefinedDose();

            //Convert to list so we can grab indices
            var dvhList = dvh.ToList();

            //Find the closest point to the requested volume,
            //If its really close, let's use it instead of interpolating
            var minVolumeDiff = dvhList.Min(d => Math.Abs(d.Volume - volume));
            var closestPoint = dvhList.First(d => Math.Abs(d.Volume - volume) == minVolumeDiff);
            if (minVolumeDiff < 0.001) return closestPoint.DoseValue;

            //Interpolate
            var index1 = dvhList.IndexOf(closestPoint);
            var index2 = closestPoint.Volume < volume ? index1 - 1 : index1 + 1;

            if (index1 >= 0 && index2 < dvh.Count())
            {
                var point1 = dvhList[index1];
                var point2 = dvhList[index2];
                var doseAtPoint = interpolar1D(point1.Volume, point2.Volume, point1.DoseValue.Dose,
                    point2.DoseValue.Dose, volume);
                return new DoseValue(doseAtPoint, point1.DoseValue.Unit);
            }
            return new DoseValue(double.NaN, closestPoint.DoseValue.Unit);
            throw new Exception(string.Format(
                "Interpolation failed. Index was : {0}, DVH Point Count : {1}, Volume was {2}, ClosestVol was {3}",
                index1, dvh.Count(), volume, minVolumeDiff));
        }

        
        /// <summary>
        ///     Returns the max dose from the dvh curve
        /// </summary>
        /// <param name="dvh">the dvh curve</param>
        /// <returns>the max dose in the same units as the curve</returns>
        public static DoseValue MaxDose(this DVHPoint[] dvh)
        {
            if (dvh.Any())
            {
                var unit = dvh.First().DoseValue.Unit;
                var maxVal = dvh.Max(d => d.DoseValue.Dose);
                return new DoseValue(maxVal, unit);
            }
            return DoseValue.UndefinedDose();
        }

        /// <summary>
        ///     Returns the min dose from the dvh curve
        /// </summary>
        /// <param name="dvh">the dvh curve</param>
        /// <returns>the minimum dose in the same units as the curve</returns>
        public static DoseValue MinDose(this DVHPoint[] dvh)
        {
            if (dvh.Any())
            {
                var unit = dvh.First().DoseValue.Unit;
                var minVal = dvh.Min(d => d.DoseValue.Dose);
                return new DoseValue(minVal, unit);
            }
            return DoseValue.UndefinedDose();
        }

        




        public static double interpolar1D(double x1, double x2, double z1, double z2, double x)
        {
            double z;
            if (x == x1) { z = z1; }
            else if (x == x2) { z = z2; }

            else { z = z1 + (z2 - z1) / (x2 - x1) * (x - x1); }
            return z;
        }
    }

    
}
