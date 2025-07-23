
namespace Treino.Entities
{

    public class Client 
    {
        public string Name{get; set;}
        public string Email{get; set;}

        public Client(){}

        public Client(string name, string Email){ Name= name; Email=Email;}

        
        public override bool Equals( object obj)
        {
            if(obj is not Client)
            {
                return false;
            }

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return  Email.GetHashCode();
        }
        

    }
}