package BASCI;

import java.util.Scanner;

public class Basico {
    public static void main(String[] args) {
        System.out.println("Escribe un numero: ");

        Scanner sc = new Scanner(System.in);

        int num = sc.nextInt(); // Registramos el numero que ingrese el user

        System.out.println("Tu numero es: 3, ¿si o no?");

        String rs = sc.next(); // Registramos la respuesta del usuario

        if (rs.equals("si") || rs.equals("s") || rs.equals("yes") || rs.equals("y")) {
            System.out.println("Tu numero es 3");
        } else if (rs.equals("no") || rs.equals("n")) {
            System.out.println("Tu numero no es 3, entinces es: " + num);
        } else {
            System.out.println("Respuesta no valida");
        }
        
        sc.close();
    }
}
