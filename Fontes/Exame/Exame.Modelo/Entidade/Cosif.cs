using System.Runtime.Serialization;

namespace Exame.Modelo.Entidade
{
    [DataContract]
    public class Cosif
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public int CodigoProduto { get; set; }
        [DataMember]
        public string Classificacao { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
