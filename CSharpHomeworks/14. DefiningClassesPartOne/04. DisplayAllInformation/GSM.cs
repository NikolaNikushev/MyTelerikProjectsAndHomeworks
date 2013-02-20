﻿using System;
using System.Text;

public class GSM
{
    public Battery Battery = new Battery(BatteryType.Type1, 0, 0);
    public Display Display = new Display(0, 0);

    private string model;
    private string manufacturer;
    private int? price;
    private string owner;

    public GSM(string model, string manufacturer) : this(model, manufacturer, null , null, null, null)
    {

    }

    public GSM(string model, string manufacturer, int price) : this(model, manufacturer, price, null, null, null)
    {
        
    }

    public GSM(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.Battery.BatteryModel = battery.BatteryModel;
        this.Battery.HoursIdle = battery.HoursIdle;
        this.Battery.HoursTalked = battery.HoursTalked;
        this.Display.Size = display.Size;
        this.Display.NumberOfColors = display.NumberOfColors;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public int? Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        endText.AppendLine(this.model);
        endText.AppendLine(this.manufacturer);
        endText.AppendLine(this.price.ToString());
        endText.AppendLine(this.owner);
        endText.AppendLine(this.Battery.BatteryModel.ToString());
        endText.AppendLine(this.Battery.HoursIdle.ToString());
        endText.AppendLine(this.Battery.HoursTalked.ToString());
        endText.AppendLine(this.Display.Size.ToString());
        endText.AppendLine(this.Display.NumberOfColors.ToString());
        string result = endText.ToString();
        return result;
    }
}
