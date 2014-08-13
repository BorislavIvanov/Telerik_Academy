class Task_2
{
    private void TheFirstIfStatement()
    {
        Potato potato = new GetPotato();
        //... 
        if (potato != null && !potato.IsRotten)
        {
            if (!potato.HasNotBeenPeeled)
            {
                Cook(potato);
            }
        }
    }

    private void TheSecondIfStatement()
    {
        if (!shouldNotVisitCell && (MIN_X <= x && x <= MAX_X) && (MIN_Y <= y && y <= MAX_Y))
        {
            VisitCell();
        }
    }
}