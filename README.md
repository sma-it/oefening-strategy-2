# oefening-strategy-2

De oefening bevat verschillende avatars, elk met hun eigen kenmerken en features. Je kan een avatar selecteren om een aanval uit te voeren en je kan ook het target (een andere avatar) selecteren. Alhoewel het programma werkt, voldoet het niet aan de vereisten van een goed programma. Gebruik het strategy pattern om de classes makkelijker te kunnen updaten als er een nieuwe versie komt.

Enkele hints:
- het ligt voor de hand dat je van een AttackBehavior voorziet. Als je daarin ook de waarde van de damage kan onthouden, dan heb minder verschillende behaviors nodig.
- in de functie 'doDamage' zie je dat niet elke avatar op dezelfde manier met damage omgaat. Zo hebben sommige avatars een shield, terwijl de mage bijvoorbeeld extra damage krijgt. Ook dit kan een behavior worden.
- is het wel nodig om de Display functie voor elke avatar te overriden?
- Tijd over? Maak dan twee extra AttackBehaviors: SuperiorSword en SuperiorBow. Ken ze een hogere damage rate toe. Zorg dan dat je een bestaande avatar tijdens de *game* deze wapens kan toekennen. Hiervoor zal je ook `Program.cs` moeten aanpassen.


