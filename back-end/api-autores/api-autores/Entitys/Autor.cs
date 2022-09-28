using System.ComponentModel.DataAnnotations;

namespace api_autores.Entitys
{
    public class Autor
    {
        //definimos la clave primaria
        [Key]
        public int codigo { get; set; }
        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength:100, 
            ErrorMessage ="Se tiene que ingresar un nombre"
            )]
        public string nombre { get; set; }  
        [Required]
        public bool estado { get; set; }
    }
}
