namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SorteosDetalleVentas
    {
        public int Id { get; set; }

        public int IdSorteos { get; set; }

        public int Numero { get; set; }

        [Column(TypeName = "money")]
        public decimal Monto { get; set; }

        [Required]
        [StringLength(128)]
        public string Id_AspNetUser { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Sorteos Sorteos { get; set; }
    }
}