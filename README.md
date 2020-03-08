# Relojes Lamport
Lamport inventó un mecanismo simple con el cual la relación sucedió antes pueda capturarse numéricamente, denominado reloj lógico. Generalmente lo importante no es que los procesos estén de acuerdo en la hora, pero sí importa que coincidan en el orden en que ocurren los eventos.

El algortimo sigue la siguiente estructura:

1. Un proceso incrementa su contador antes de cada evento que ocurra en ese proceso.
1. Cuando un proceso envía un mensaje, este incluye su contador en el envío.
1. Al recibir un mensaje, se actualiza el contador del receptor si es necesario, al mayor entre su propio contador y la marca de tiempo recibida en dicho mensaje.

El programa presentado simula 3 procesos, los cuales intercambian información entre ellos. En cada proceso se puede seleccionar el destinatario del mensaje. Siguiendo el algoritmo de Lamport, el programa actualiza los relojes de los procesos y muestra en la parte inferior el registro de los eventos que ocurrieron 

Desarrollado en .Net Framework 

