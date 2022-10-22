# DSR_PLC_simulator
## Simulator Task

### Matlab
- vytvoriť skript pre výpočet parametrov predpísaného spojitého regulátora pre systém v tvare K / (Ts + 1) na základe zvolených časových konštánt URO
- zvoliť vhodnú periódu vzorkovania a diskretizovať navrhnutý regulátor na základe predpísanej aproximačnej metódy
- poslať vypočítané hodnoty diskrétneho regulátora a periódu vzorkovania do DoMore Simulátora prostredníctvom protokolu Modbus/TCP

### DoMore Simulátor
- nastaviť simulovaný proces na základe zadanej časovej konštanty T (dopravné oneskorenie = 0, šum = 0.002)
- implementovať prepočet medzi ADC/DAC hodnotami a hodnotami y(k)/u(k) na základe zadaných rozsahov prevodníkov, zosilnenie systému K brať do úvahy pri výpočte DAC hodnoty, t.j. DAC <- K * u(k)
- implementovať navrhnutý diskrétny regulátor na riadenie simulovaného procesu (parametre regulátora a perióda vzorkovania budú nastavovateľné z Matlabu cez Modbus/TCP)
- umožniť čítanie hodnôt y(k), u(k), e(k) a zápis w(k) cez Modbus/TCP
- umožniť čítanie bitov X0-X15 a zápis bitov Y0-Y15 cez Modbus/TCP

### Visual Studio C#/C++
- implementovať komunikáciu s DoMore Simulátorom cez Modbus/TCP
- vytvoriť grafickú aplikáciu pre vizualizáciu priebehu veličín y(k), u(k) a e(k) v reálnom čase vo forme grafu
- umožniť nastavovanie referenčnej hodnoty w(k)
- vizualizovať stav digitálnych vstupov X0-X15 a umožniť zapínanie/vypínanie digitálnych výstupov Y0-Y15
