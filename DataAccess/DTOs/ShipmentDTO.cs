using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe representant les shipments
/// </summary>
public class ShipmentDTO : AbstractDTO<int> {

    /// <summary>
    /// Déclaration de propriété
    /// </summary>


    public ShipmentServiceEnum Service { get; set; }
    public string? TrackingNumber { get; set; } = null!;
    public int? ShippingOrderID { get; set; } = null!;
    public byte[] RowVersion { get; set; } = null!;


    /// <summary>
    /// Déclaration de propriété de navigation
    /// </summary>
    public virtual ShipmentOrderDTO ShippingOrder { get; set; } = null!;


    /// <summary>
    /// Déclaration de random permettant de créer un string alpha numérique aléatoire
    /// </summary>
    [NotMapped]
    private static readonly Random RANDOM = new Random();


    /// <summary>
    /// Fonction de création du tracking number aléatoire sous forme alphanuméric consistant de la propriété random ainsi que d'un const chars représentant toute les possibilitées
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>

    private static string RandomString(int length) {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => {
                return s[RANDOM.Next(s.Length)];
            }).ToArray());
    }


    /// <summary>
    /// Constructeur permettant de generer la fonction RandomString
    /// </summary>
    public ShipmentDTO() : base() {
        this.TrackingNumber = RandomString(15);
    }


    /// <summary>
    /// Constructeur manuel
    /// </summary>
    /// <param name="ShippingId"></param>
    /// <param name="Service"></param>
    public ShipmentDTO(int ShippingId, ShipmentServiceEnum Service) {
        this.ShippingOrderID = ShippingId;
        this.Service = Service;
        this.TrackingNumber = RandomString(15);



    }


    /// <summary>
    /// Constructeur EF Core
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Service"></param>
    /// <param name="ShippingId"></param>
    /// <param name="TrackNumber"></param>
    /// <param name="RowVersion"></param>
    protected ShipmentDTO(int Id, ShipmentServiceEnum Service, int ShippingId, string TrackNumber, byte[] RowVersion) {
        this.Id = Id;
        this.ShippingOrderID = ShippingId;
        this.TrackingNumber = TrackNumber;
        this.RowVersion = RowVersion;
        this.Service = Service;
    }



    /// <summary>
    /// Constructeur créant l'énumération de shipment service
    /// </summary>
    public enum ShipmentServiceEnum {
        PUROLATOR, CANADAPOST, FEDEX
    }


    public override string ToString() {
        return this.Id.ToString() + " - " + this.Service.ToString() + " " + this.TrackingNumber;
    }


}
