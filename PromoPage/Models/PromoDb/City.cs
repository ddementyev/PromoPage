namespace PromoPage.Models.PromoDb
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("City")]
        [Required]
        [StringLength(50)]
        public string CityName { get; set; }
    }
}
