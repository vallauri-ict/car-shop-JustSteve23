using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using venditaVeicoliDLLProject;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ReflectionCssPocProject
{
    public class Utils
    {
        public class SerializableBindingList<T> : BindingList<T> { }
        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static string ToCsvString<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            StringBuilder csvdata = new StringBuilder();
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                csvdata.AppendLine(string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray()));
            }
            return csvdata.ToString();
        }
        public static void SerializeToCsv<T>(IEnumerable<T> objectlist,string pathName,string separator="|")
        {
            string datatosave = Utils.ToCsvString(objectlist, separator);
            File.WriteAllText(pathName, datatosave);
        }

        public static void SerializeToXml<T>(SerializableBindingList<T> objectlist, string pathName)
        {
            XmlSerializer x = new XmlSerializer(typeof(SerializableBindingList<T>));
            TextWriter w = new StreamWriter(pathName);
            x.Serialize(w, objectlist);
        }

        public static void SerializeToJson<T>(IEnumerable<T> objectlist, string pathName)
        {
            string json = JsonConvert.SerializeObject(objectlist,Formatting.Indented);
            File.WriteAllText(pathName,json);
        }

        public static void createHTML<T>(IEnumerable<T> objList, string homePath,string skName= @".\www\indexSkeleton.html")
        {
            string _div="";
            string html = File.ReadAllText(skName);
            html = html.Replace("{{head-title}}","AUTOVALLAURI");
            html = html.Replace("{{body-title}}", "SALONE AUTOVALLAURI");

            foreach (var item in objList)
            {
                _div +=$"<div><span>{(item as veicolo).Marca}</span> <br> <span>{(item as veicolo).Modello}</span></div>";
            }
            html = html.Replace("{{body-subtitle}}", "Veicoli");
            html = html.Replace("{{main-content}}", _div);
            

            File.WriteAllText(homePath,html);
        }

        #region MSWord
        public static void WordDocumentCreation(SerializableBindingList<veicolo> objList)
        {
            string filepath = "veicoli.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Create(filepath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = doc.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Add heading
                Paragraph headingPar = createHeading("VEICOLI DISPONIBILI");
                body.AppendChild(headingPar);

                foreach (var item in objList)
                {
                    string type = null;
                    if (item is auto)
                        type = "AUTO";
                    else
                        type = "MOTO";
                    Paragraph newPar = createParagaph(type,item.Marca,item.Modello,item.Cilindrata.ToString(),item.PotenzaKw.ToString(),item.Prezzo);
                    body.AppendChild(newPar);
                }
            }
        }
        private static Paragraph createHeading(string content)
        {
            Paragraph heading = new Paragraph();
            Run r = new Run();
            Text t = new Text(content);
            ParagraphProperties pp = new ParagraphProperties();
            RunProperties rp = new RunProperties();
            rp.Bold = new Bold();
            rp.FontSize = new FontSize() { Val = "42" };
            // we set the style
            pp.ParagraphStyleId = new ParagraphStyleId() { Val = "Titolo1" };
            // we set the alignement
            pp.Justification = new Justification() { Val = JustificationValues.Center };
            heading.Append(pp);
            r.Append(rp);
            r.Append(t);
            r.AppendChild(new Break());
            heading.Append(r);
            return heading;
        }

        private static Paragraph createParagaph(string tipo,string txtMarca,string txtModello,string txtCil,string txtPot,double prezzo)
        {
            Paragraph p = new Paragraph();
            // Set the paragraph properties
            ParagraphProperties pp = new ParagraphProperties(new ParagraphStyleId() { Val = "Titolo1" });
            pp.Justification = new Justification() { Val = JustificationValues.Left };
            // Add paragraph properties to your paragraph
            p.Append(pp);

            //Run
            Run r = new Run();
            RunProperties rp = new RunProperties();
            rp.Bold = new Bold();
            // Always add properties first
            r.Append(rp);
            r.AppendChild(new Text(txtMarca+" -"+txtModello) { Space = SpaceProcessingModeValues.Preserve });
            r.AppendChild(new Break());
            p.Append(r);
            
            //Run2
            Run r2 = new Run();
            RunProperties rp2 = new RunProperties();
            rp2.Italic = new Italic();
            r2.Append(rp2);
            // Always add properties first
            r2.AppendChild(new Text("   -MOTORIZZAZIONE ") { Space = SpaceProcessingModeValues.Preserve });
            r2.AppendChild(new Break());
            r2.AppendChild(new Text("   -Potenza: " + txtPot+"kw   -Cilindrata: "+txtCil+ " cm2") { Space = SpaceProcessingModeValues.Preserve });
            r2.AppendChild(new Break());
            r2.AppendChild(new Text("  -Prezzo: "+prezzo+"€"));
            p.Append(r2);

            return p; 
        }
        #endregion
    }
}
