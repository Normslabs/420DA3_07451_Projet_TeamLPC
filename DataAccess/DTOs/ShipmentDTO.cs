using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.Identity.Client;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Classe representant les shipments
/// </summary>
public class ShipmentDTO : AbstractDTO<int> {

    /// <summary>
    /// Déclaration de propriété
    /// </summary>

    public byte[] RowVersion { get; set; } = null!;

    public ShipmentServiceEnum Service {  get; set; } 
    public int? ShippingOrderID { get; set; } = null!;

    public string? TrackingNumber { get; set; } = null!;


    /// <summary>
    /// Déclaration de propriété de navigation
    /// </summary>
    public ShipmentOrderDTO ShippingOrder { get; set; } = null!;


    /// <summary>
    /// Déclaration de random permettant de créer un string alpha numérique aléatoire
    /// </summary>
    [NotMapped]
    private static Random random = new Random();


    /// <summary>
    /// Fonction de création du tracking number aléatoire sous forme alphanuméric consistant de la propriété random ainsi que d'un const chars représentant toute les possibilitées
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>

    private static string RandomString(int length) {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => {
                return s[random.Next(s.Length)];
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
    protected ShipmentDTO(int Id, ShipmentServiceEnum Service, int ShippingId, string TrackNumber, byte[] RowVersion ) 
    {
        this.Id = Id;
        this.ShippingOrderID = ShippingId;
        this.TrackingNumber = TrackNumber;
        this.RowVersion = RowVersion;
        this.Service = Service;
    }



    /// <summary>
    /// Constructeur créant l'énumération de shipment service
    /// </summary>
    public enum ShipmentServiceEnum 
    {
        PUROLATOR, CANADAPOST, FEDEX
    }





}
