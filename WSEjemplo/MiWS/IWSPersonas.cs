﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {
        [OperationContract]
        Persona ObtenerPersona(string Id);
    }

    [DataContract]
    public class Persona : BaseRespuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }
    }

    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string MensajeRespuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }

}
