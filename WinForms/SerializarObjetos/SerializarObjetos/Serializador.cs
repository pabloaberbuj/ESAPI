using System.Xml;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Forms;
namespace SerializarObjetos
{
    public class Serializador
    {
        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }


        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }

        public static void writeObjectAsJson(string file, object theObj)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(theObj,Newtonsoft.Json.Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            }));
        }

        /// <summary>
        /// Agrega un objeto en la última posición de una lista en Json
        /// 
        /// </summary>
        /// <typeparam name="T">El tipo de la lista => List<T></typeparam>
        /// <param name="file">la ruta del archivo</param>
        /// <param name="theObj">el objeto para agregar</param>
        public static void appendObjectAsJson<T>(string file, object theObj)
        {
            BindingList<T> lista = readJsonList<T>(file);
            lista.Add((T)theObj);
            writeObjectAsJson(file, lista);
        }
        /// <summary>
        /// Lee una lista desde un archiov Json
        /// </summary>
        /// <typeparam name="T">El tipo de la lista => List<T></typeparam>
        /// <param name="file">la ruta del archivo</param>
        /// <returns>Devuelve una lista del tipo indicado List<T></returns>
        public static BindingList<T> readJsonList<T>(string file)
        {
            try
            {
                BindingList<T> lista = JsonConvert.DeserializeObject<BindingList<T>>(File.ReadAllText(file));
                return lista;
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show("No existe el archivo: " + file);
                BindingList<T> lista = new BindingList<T>();
                return lista;
            }
        }

        public static T readJson<T>(string file)
        {
            try
            {
                var settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Auto;
                T t = JsonConvert.DeserializeObject<T>(File.ReadAllText(file), settings);
                return t;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
