#include <LiquidCrystal.h>

char x;
String data;
float temp;
int yellow_light = A2;
int red_light = A3;
int green_light = A1;
int buzzer = 10;
LiquidCrystal lcd(11,12,4,5,6,7);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(57600);
  delay(200);
  pinMode(yellow_light, OUTPUT);
  pinMode(red_light, OUTPUT);
  pinMode(green_light, OUTPUT);
  pinMode(buzzer, OUTPUT);
  lcd.begin(16,2);
  lcd.print("CPU Temp:");
}

void loop() {
  Get_Data();

  lcd.setCursor(0,1);
  lcd.print(temp);

//setCursor(1, 1);

  if (temp < 50.0 ) {
    digitalWrite(green_light, HIGH);
    digitalWrite(red_light, LOW);
    digitalWrite(yellow_light, LOW);
    analogWrite(buzzer, 0);
  }
  else if ((temp >= 50.0) && (temp <= 79)) {
    digitalWrite(red_light, LOW);
    digitalWrite(green_light, LOW);
    digitalWrite(yellow_light, HIGH);
    analogWrite(buzzer, 0);
  }
  else if ((temp > 79.0) && (temp < 90)) {
    digitalWrite(red_light, HIGH);
    digitalWrite(green_light, LOW);
    digitalWrite(yellow_light, LOW);
    analogWrite(buzzer, 0);
  }
  if (temp >= 90) {
    digitalWrite(red_light, HIGH);
    digitalWrite(green_light, LOW);
    digitalWrite(yellow_light, LOW);
    analogWrite(buzzer, 20);
  }


}


void Get_Data()
{

  while (Serial.available() > 0) {

    x = Serial.read();
    if (x == '\n') {
      break;
    }
    else {
      data += x;
    }
  }

  if (x == '\n') {

    temp = data.toFloat();
    x = 0;
    data = "";
    Serial.println((String)"Temp = " + temp);

  }

}
