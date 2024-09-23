using Microsoft.AspNetCore.Identity;

namespace ProjetoBE.Models
{
    //Classe com os atributos desses dados
    public class ApplicationUser : IdentityUser
    {
        
        public string Nome {  get; set; }
        public DateTime DataNasc {  get; set; }


    }
}
