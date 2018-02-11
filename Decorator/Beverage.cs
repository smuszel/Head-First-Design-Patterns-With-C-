public abstract class Beverage
{
    private string _description = "Unknown Beverage";
    public string Description 
    { 
        get
        {
            return GetDescription();
        }
        set
        {
            _description = value;
        }
    }

    public abstract double Cost();
    public virtual string GetDescription()
    {
        return this._description;
    }
}