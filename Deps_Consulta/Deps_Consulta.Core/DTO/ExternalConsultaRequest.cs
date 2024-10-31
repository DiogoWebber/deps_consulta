using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Deps_Consulta.Core.DTO
{
    public class ExternalConsultaRequest
    {
        [JsonProperty("documento")]
        public string Documento { get; set; }
        
        [JsonProperty("userId")]
        public string UserId { get; set; }
        
        [JsonProperty("produto")]
        public ProdutoDTO Produto { get; set; } // Adicionando a propriedade Produto
    }
    
    public class ProvedorRequest
    {
        [JsonProperty("idProvedores")]
        public int IdProvedores { get; set; }

        [JsonProperty("nomeProvedor")]
        public string NomeProvedor { get; set; }
    }
    public class ProdutoDTO
    {
        [JsonProperty("idProduto")]
        public string IdProduto { get; set; }

        [JsonProperty("nomeProduto")]
        public string NomeProduto { get; set; }

        [JsonProperty("credito")]
        public decimal Credito { get; set; }

        [JsonProperty("provedores")]
        public List<ProvedorDTO> Provedores { get; set; } 
    }

    public class ProvedorDTO
    {
        [JsonProperty("idProvedor")]
        public string IdProvedor { get; set; } // Deve corresponder ao tipo

        [JsonProperty("nomeProvedor")]
        public string NomeProvedor { get; set; }
    }
}