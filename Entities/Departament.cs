using MeuProjeto.Entities;
using MeuProjeto.Entidades.Enums;



namespace MeuProjeto.Entidades.Enums
{
    class Departament
    {
        //public int Id { get; set; }
        public string Name { get; set; } = String.Empty ;

        public override string ToString()
        {
            return $"Name of the Department: {Name}";
        }
    }
}