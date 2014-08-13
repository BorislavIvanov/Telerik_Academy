public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        Peel(potato);
        Peel(carrot);

        Cut(potato);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(potato);
        bowl.Add(carrot);
    }

    private void Potato GetPotato()
    {
        //...
    }

    private void Carrot GetCarrot()
    {
        //...
    }

    private void Peel(Vegetable type)
    {
        //...
    }

    private void Bowl GetBowl()
    {   
        //... 
    }

    private void Cut(Vegetable type)
    {
        //...
    }
}
