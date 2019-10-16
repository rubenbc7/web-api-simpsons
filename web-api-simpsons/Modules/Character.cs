using System;


namespace web_api_simpsons.Modules
{
    public class Character
    {
        Int64 id;
        string firstName;
        string secondName;
        string lastName;
        int age;
        string description;

        public Character(){}

        //nombre de la clase dejas el cursosr y te hce un constructor
        public Character(Int64 id, string firstName, string secondName, string lastName, int age, string description)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.description = description;
            this.id = id;
        }


//Clic en seleccionar todo los int/strin"caracteristicas" saldra un bombillo
//y clic derecho y selecciona "Encapsular, pero seguir usando campos"
        public string FirstName 
        { 
            get => firstName; 
            set => firstName = value;
        }
        //esto se hace para entender mejor, aun que no es la manera correta de hacer
        public string SecondName 
        {
             get => secondName; 
             set => secondName = value; 
        }
        //es lo mismo que esto
        public Int64 Id  { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Description { get => description; set => description = value; }
    }
}