namespace Notenplana23
{
    internal interface IViewLoggin
    {
        IViewRegestrierung ViewRegestrierung { get; set; }
        IViewHauptprogramm ViewHauptprogramm { get; set; }
        IControllerProfile ControllerProfile { get; set; }
    }
}