using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace My_WS_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {

        [OperationContract]
        Persona obtenerPersona(string Identificacion);


        // TODO: agregue aquí sus operaciones de servicio
    }



    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Persona : BaseRespuesta
    {
        [DataMember]
        public string nombre { get; set; }
        public int edad { get; set; }

    }

    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string mensajeRespuesta { get; set; }
        [DataMember]
        public string error { get; set; }
    }
}
