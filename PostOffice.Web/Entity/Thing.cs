using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostOffice.Web.Entity
{
    public class Thing
    {
        /// <summary>
        /// Идентификационный номер
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификационный номер посылки, которой принадлежит
        /// </summary>
        public int ParcelId { get; set; }

        /// <summary>
        /// Принадлежность
        /// </summary>
        [ForeignKey(nameof(ParcelId))]
        public virtual Parcel Parcel { get; set; }
    }
}