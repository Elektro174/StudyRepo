

#include <OneWire.h>
#include <DallasTemperature.h>
#include <SimpleDHT.h>
#include <SPI.h>
#include <ShiftedLCD.h>

byte TempDHT = 0;
byte Humidity = 0;
int pinDHT11 = 2;
int Svet = 0;
//float SetTemperature = 24;
float Hyster3 = 0.25;
int flag = 0;
//int clicks = 1;
bool btnState = 0;

static bool relayState1;
static bool relayState2;
static bool relayState3;
static bool relayState4;

#define SetTemp 24
#define Setsvet 40
#define SetTempDHT 24
#define SetHumidity 26
#define Hyster1 2
#define Hyster2 5
#define ONE_WIRE_BUS 3

int SetDHT_t = SetTempDHT;
int SetDHT_h = SetHumidity;
int SetSvet = Setsvet;
int SetTemperature = SetTemp;


SimpleDHT11 dht11(pinDHT11);
OneWire oneWire(ONE_WIRE_BUS);
DallasTemperature sensor(&oneWire);
DeviceAddress insideThermometer, outsideThermometer;
LiquidCrystal lcd(10);

void setup() {

  Serial.begin (9600);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  lcd.begin(16, 2);
  sensor.begin();
  sensor.setResolution(12);
  pinMode(9, INPUT_PULLUP);

}

void loop() {
  unsigned long tmr1;
  if (millis() - tmr1 > 2000) {
    tmr1 = millis();
    if ((dht11.read(&TempDHT, &Humidity, NULL)) != 0) {
      //Serial.println ("Error");
      return;
    }
  }

  if (TempDHT < (SetTempDHT - Hyster1 )) {
    relayState1 = !HIGH;
    digitalWrite(4, HIGH);
  } else if (TempDHT > (SetTempDHT + Hyster1 )) {
    relayState1 = !LOW;
    digitalWrite(4, LOW);
  }

  if (Humidity < (SetHumidity - Hyster2 )) {
    relayState2 = !HIGH;
    digitalWrite(5, HIGH);
  } else if (Humidity > (SetHumidity + Hyster2 )) {
    relayState2 = !LOW;
    digitalWrite(5, LOW);
  }


  Svet = analogRead(A6);
  Svet = map(Svet, 0, 1023, 100, 0);
  if (Svet < Setsvet) {
    relayState4 = !LOW;
    digitalWrite(6, LOW);
  }
  else  if (Svet > Setsvet) {
    relayState4 = !HIGH;
    digitalWrite(6, HIGH);
  }
  

  float temperature;
  sensor.requestTemperatures();
  temperature = sensor.getTempCByIndex(0);
  unsigned long timing1;
  if (millis() - timing1 > 2400) {
    timing1 = millis();
    // Serial.print("Temp18b20 ");
    // Serial.print(temperature);

    if (temperature <= (SetTemp - Hyster3 )) {
      // Serial.print(" Relay_3 "); Serial.println("On");
      relayState3 = !LOW;
      digitalWrite(7, LOW);
    }
    else if (temperature >= (SetTemp + Hyster3 )) {
      //   Serial.print(" Relay_3 "); Serial.println("Off");
      relayState3 = !HIGH;
      digitalWrite(7, HIGH);
    }
  }
  Serial.print(relayState1);
  Serial.print(',');
  Serial.print(relayState2);
  Serial.print(',');
  Serial.print(relayState3);
  Serial.print(',');
  Serial.print(relayState4);
  Serial.print(',');

  Serial.print(SetDHT_t);
  Serial.print(',');
  Serial.print(SetDHT_h);
  Serial.print(',');
  Serial.print(SetSvet);
  Serial.print(',');
  Serial.print(SetTemperature);
  Serial.print(',');

  Serial.print(TempDHT);
  Serial.print(',');
  Serial.print(Humidity);
  Serial.print(',');
  Serial.print(Svet);
  Serial.print(',');
  Serial.print(temperature);
  delay(200);
 
  if (digitalRead(8) == HIGH && flag == 0) 
  {

    lcd.setCursor(0, 0);
    lcd.print("TempDHT ");
    lcd.print(TempDHT);
   // lcd.print(" Rel ");
   // lcd.print(relayState1);


    lcd.setCursor(0, 1);
    lcd.print("HumDHT  ");
    lcd.print(Humidity);
   // lcd.print(" Rel ");
    //lcd.print(relayState2);

    digitalWrite(8, !digitalRead(8));

    flag = 1;
  }

  if (digitalRead(8) == LOW && flag == 1) 
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Svet ");
    lcd.print(Svet);
    //lcd.print(" Rel ");
    //lcd.print(relayState3);

    lcd.setCursor(0, 1);
    lcd.print("temp ");
    lcd.print(temperature);
   // lcd.print(" Rel ");
    //lcd.print(relayState4);
    
    flag = 0; 
  }

}
