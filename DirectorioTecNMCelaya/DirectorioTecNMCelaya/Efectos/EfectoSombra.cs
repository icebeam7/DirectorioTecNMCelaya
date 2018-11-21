using Xamarin.Forms;

namespace DirectorioTecNMCelaya.Efectos
{
    public class EfectoSombra : RoutingEffect
    {
        public float Radio { get; set; }
        public Color Color { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public EfectoSombra() : base("DirectorioTecNMCelaya.EfectoSombraLabel") { }
    }
}
