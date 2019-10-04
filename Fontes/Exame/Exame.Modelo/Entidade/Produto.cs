using System.Runtime.Serialization;

namespace Exame.Modelo.Entidade
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
