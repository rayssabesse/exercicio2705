namespace cafeteira
{
    public class cm
    {
        public int acucarDisponivel = 250;
        public bool validade; 

        public string fazercafe(int quantidadeacucar){
            if (acucarDisponivel >= quantidadeacucar) {
                acucarDisponivel = acucarDisponivel - quantidadeacucar;
                validade = false;
                return "Seu café está sendo preparado com "+quantidadeacucar+"g de acucar!!";
            }
            else {
                validade = false;
                return "Não há açúcar suficiente, tente novamente!";
            }
        }
        public string fazercafe(){
            acucarDisponivel = acucarDisponivel - 10;
            return "Seu café está sendo preparado com a quantidade padrão de açúcar!!";
        }
    }
}