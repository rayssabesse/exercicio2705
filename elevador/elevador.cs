using System;

namespace elevador
{
    public class general
    {
        public static int floor = 0;
        public static void initialize()
        {
            Console.WriteLine($@"
            ---------------------------------------------------
                Total de andares = {floor}
            ---------------------------------------------------
                Andar atual  elevador social = {social.cfloorp}
            ---------------------------------------------------
                Andar atual elevador de serviço = {service.cfloorb}
            ---------------------------------------------------
                Máximo de pessoas = {social.people}
            ---------------------------------------------------
                Total de pessoas = {social.cpeople}
            ---------------------------------------------------
                Máximo de caixas = {service.box}
            ---------------------------------------------------
                Total de caixas = {service.cbox}
            ---------------------------------------------------  
            ");
        }
    }


}