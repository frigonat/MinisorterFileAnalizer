using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace MinisorterFileAnalizer.Models
{
    public class FormData
    {
        public const string C_FORMS = "Forms";
        public const string C_FORM = "Form";
        public const string C_NAME = "Name";
        public const string C_SIZE = "Size";
        public const string C_WIDTH = "Width";
        public const string C_HEIGHT = "Height";
        public const string C_LOCATION = "Location";
        public const string C_WINDOW_STATE = "WindowState";
        public const string C_X = "X";
        public const string C_Y = "Y";
        public const string C_FORMS_FILE = "forms.xml";

        public string FormName { get; set; }
        public string FormWindowState { get; set; }
        public int FormSize_Width { get; set; }
        public int FormSize_Height { get; set; }
        public int FormLocation_X { get; set; }
        public int FormLocation_Y { get; set; }

        /// <summary>
        /// Save the size and position for the form it's passed as a parameter.- 
        /// </summary>
        /// <param name="currentForm">Form which size and position needs to be saved.-</param>
        public static void SaveFormSizeAndPosition(Form currentForm)
        {
            XmlDocument doc;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            string archivoDeFormularios = $"{rutaArchivo}{Path.DirectorySeparatorChar}{C_FORMS_FILE}";

            //Verficar si el archivo existe, lo creo.-
            if (File.Exists(archivoDeFormularios))
                doc = retrieveFormsFile(archivoDeFormularios);
            else
                doc = createFormsFile(archivoDeFormularios);

            //Se verifica si existe el nodo con el nombre del form.-
            XmlNodeList? formularios = doc.SelectNodes($"//Form[Name='{currentForm.Name}']");
            if (formularios.Count > 0)
            {
                XmlNode nodoFormularioBuscado = formularios[0];

                XmlNode windowStateNode = nodoFormularioBuscado.SelectSingleNode(C_WINDOW_STATE);
                if (windowStateNode != null)
                    windowStateNode.InnerText = currentForm.WindowState.ToString();

                //Si el formulario no está maximizado, guardo su tamaño y posición.-
                if (currentForm.WindowState == System.Windows.Forms.FormWindowState.Normal)
                {
                    XmlNode widthNode = nodoFormularioBuscado.SelectSingleNode($"{C_SIZE}/{C_WIDTH}");
                    if (widthNode != null)
                        widthNode.InnerText = currentForm.Width.ToString();

                    XmlNode heightNode = nodoFormularioBuscado.SelectSingleNode($"{C_SIZE}/{C_HEIGHT}");
                    if (heightNode != null)
                        heightNode.InnerText = currentForm.Height.ToString();

                    XmlNode xNode = nodoFormularioBuscado.SelectSingleNode($"{C_LOCATION}/{C_X}");
                    if (xNode != null)
                        xNode.InnerText = currentForm.Location.X.ToString();

                    XmlNode yNode = nodoFormularioBuscado.SelectSingleNode($"{C_LOCATION}/{C_Y}");
                    if (yNode != null)
                        yNode.InnerText = currentForm.Location.Y.ToString();
                }
            }
            else
            {
                XmlNode element1 = doc.SelectSingleNode(C_FORMS);
                XmlElement elementForm = doc.CreateElement(string.Empty, C_FORM, string.Empty);
                element1.AppendChild(elementForm);

                XmlElement elementFormName = doc.CreateElement(string.Empty, C_NAME, string.Empty);
                XmlText texto_formName = doc.CreateTextNode(currentForm.Name.ToString());
                elementFormName.AppendChild(texto_formName);
                elementForm.AppendChild(elementFormName);

                XmlElement elementWindowState = doc.CreateElement(string.Empty, C_WINDOW_STATE, string.Empty);
                XmlText texto_WindowState = doc.CreateTextNode(currentForm.WindowState.ToString());
                elementWindowState.AppendChild(texto_WindowState);
                elementForm.AppendChild(elementWindowState);

                //Size
                XmlElement elementSize = doc.CreateElement(string.Empty, C_SIZE, string.Empty);
                elementForm.AppendChild(elementSize);

                XmlElement elementWidth = doc.CreateElement(string.Empty, C_WIDTH, string.Empty);
                XmlElement elementHeight = doc.CreateElement(string.Empty, C_HEIGHT, string.Empty);
                elementSize.AppendChild(elementWidth);
                elementSize.AppendChild(elementHeight);

                XmlText texto_W = doc.CreateTextNode(currentForm.Width.ToString());
                XmlText texto_H = doc.CreateTextNode(currentForm.Height.ToString());
                elementWidth.AppendChild(texto_W);
                elementHeight.AppendChild(texto_H);

                //Location
                XmlElement elementLocation = doc.CreateElement(string.Empty, C_LOCATION, string.Empty);
                elementForm.AppendChild(elementLocation);

                XmlElement elementX = doc.CreateElement(string.Empty, C_X, string.Empty);
                XmlElement elementY = doc.CreateElement(string.Empty, C_Y, string.Empty);
                elementLocation.AppendChild(elementX);
                elementLocation.AppendChild(elementY);

                XmlText texto_X = doc.CreateTextNode(currentForm.Location.X.ToString());
                XmlText texto_Y = doc.CreateTextNode(currentForm.Location.Y.ToString());
                elementX.AppendChild(texto_X);
                elementY.AppendChild(texto_Y);
            }

            doc.Save(archivoDeFormularios);
        }

        /// <summary>
        /// Gets the size and position for the form whose name is passed as a parameter.-
        /// </summary>
        /// <param name="currentForm"></param>
        public static FormDataResponse GetFormSizeAndPosition(string currentForm)
        {
            XmlDocument doc;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            string archivoDeFormularios = $"{rutaArchivo}{Path.DirectorySeparatorChar}{C_FORMS_FILE}";

            //Verficar si el archivo existe, lo creo.-
            if (File.Exists(archivoDeFormularios))
            {
                doc = retrieveFormsFile(archivoDeFormularios);

                XmlNodeList forms = doc.SelectNodes($"//Form[Name='{currentForm}']");
                if (forms.Count > 0)
                {
                    return new FormDataResponse
                    {
                        StatusCode = 200,
                        Data = new FormData
                        {
                            FormName = currentForm,
                            FormWindowState = forms[0].SelectSingleNode(C_WINDOW_STATE)?.InnerText ?? "Normal",
                            FormSize_Width = int.Parse(forms[0].SelectSingleNode($"{C_SIZE}/{C_WIDTH}")?.InnerText ?? "800"),
                            FormSize_Height = int.Parse(forms[0].SelectSingleNode($"{C_SIZE}/{C_HEIGHT}")?.InnerText ?? "600"),
                            FormLocation_X = int.Parse(forms[0].SelectSingleNode($"{C_LOCATION}/{C_X}")?.InnerText ?? "100"),
                            FormLocation_Y = int.Parse(forms[0].SelectSingleNode($"{C_LOCATION}/{C_Y}")?.InnerText ?? "100")
                        }
                    };
                }
                else
                {
                    return new FormDataResponse
                    {
                        StatusCode = 404,
                        Message = $"No se ha encontrado una sección con el nombre {C_FORM} en el archivo {C_FORMS_FILE}.-"
                    };
                }
            }
            else
            {
                return new FormDataResponse
                {
                    StatusCode = 404,
                    Message = $"No se ha podido hallar el archvo {C_FORMS_FILE}.-"
                };
            }
        }

        /// <summary>
        /// Creates a file to store the size and position of the forms. The file will be created in the same directory where the executable is located.-
        /// </summary>
        /// <param name="fileName">Name for the file to be created.</param>
        /// <returns>An XmlDocument with the basics data, ready to be filled with the information about forms.-</returns>
        private static XmlDocument createFormsFile(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmld = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmld, root);
            XmlElement element1 = doc.CreateElement(string.Empty, C_FORMS, string.Empty);
            doc.AppendChild(element1);

            doc.Save(fileName);

            return doc;
        }

        /// <summary>
        /// Retrives the forms data, stored in the file specified as a para<meter.-
        /// </summary>
        /// <param name="fileName">The name of the file to be retrieved, including the full path.-</param>
        /// <returns>An XmlDocument containing the contents of the specified file.</returns>
        private static XmlDocument retrieveFormsFile(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            return doc;
        }
    }
}
