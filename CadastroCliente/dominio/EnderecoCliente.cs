namespace CadastroCliente.dominio
{
    internal class EnderecoCliente
    {
        public int id { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
    }
}
