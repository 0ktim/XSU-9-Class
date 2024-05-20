void setup() {
pinMode(2, OUTPUT);
Serial.begin(9600);
}
void loop() {
  if (Serial.available() > 0) {
    String n = Serial.readString();
    Serial.println(n);
    if(n=="on"){
      digitalWrite(2, HIGH);
    }
    else if (n=="off"){
     digitalWrite(2, LOW);
    }
    else{}
  }
}
