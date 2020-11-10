using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "André Felipe Ricarti", Cpf = "390.607.498-63", Email = "ricarti.182@gmail.com" };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Projetos\C#\Learn_CSharp\01_SerializarXML\Arquivo\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
