using Pamoka6;
using Pamoka6.Models;


//Earth konstruktorius padaro Erth su prarametrasi kuriuos paduodam
Earth earth1 = new Earth(15f, 2020f);                        

//Class Calculations perduodame Erth konstruktoriu ir jo reikšmes
var calculations = new Calculations(earth1);
var kita = new Kita(calculations);

