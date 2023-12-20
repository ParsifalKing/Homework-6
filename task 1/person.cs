class Person
{
    public string FirstName = "Davron";
    public string LastName = "Ziyoev";
    public int Age = 2007;
    public string _Address = "Dushanbe";



    public string GetFullName()
    {
       return $"{FirstName} {LastName}"; 
    } 
    public int GetBirthDay(){
        return Age;
    }
    public string Address()
    {
        return $"{_Address}";
    }

}