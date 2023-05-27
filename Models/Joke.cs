namespace JokeRegistryWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }   
        public string JokeAnswer { get; set; }
        //prop is the shortcut to create these properties/attributes

        //ctor is the shortcut to create a constructor
        public Joke()
        {
            
        }
    }
}
