namespace ListaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList list = new ContactList();

            Contact contato1 = new Contact("Bernado", "123");
            list.Add(contato1);

            Contact contato2 = new Contact("Ana", "345");
            list.Add(contato2);

            Contact contato3 = new Contact("Caue", "567");
            list.Add(contato3);

            list.Add(new Contact("Bruna", "987"));

            list.RemoveByName("Bruna");
            list.RemoveByName("ANA".ToLower());
            list.RemoveByName("Caue");

        }
    }
}
