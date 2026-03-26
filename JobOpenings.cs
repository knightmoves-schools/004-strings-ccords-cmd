namespace knightmoves;
public class JobOpenings
{   
    public string FirstName = "BigTony";
    public string JobTitle = "Entrepreneur";
    public string City = "New York";

    public string PrintOpening(){
        return $@"Snitches get no bitches {FirstName}, {JobTitle}, {City}, 
            beep boop beep";
    }
}
