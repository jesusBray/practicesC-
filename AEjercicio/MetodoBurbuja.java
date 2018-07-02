package AEjercicio;
import java.util.Scanner;
import javax.swing.JOptionPane;
public class MetodoBurbuja{

	int vector[];
	int aux,dato;
	Scanner entrada = new Scanner(System.in);
	public void burbu(){

		System.out.print("Digite la cantidad de elementos --> ");
		int dato = entrada.nextInt();
		
		//Aqui se pone el numero de elemtos con for;
		vector = new int[dato];
		for (int i=0;i<dato;i++) {
			System.out.println((i+1)+"Digite un numero..");
			vector[i] = entrada.nextInt();
		}
		
		//Metodo burbuja..
		for (int i=0;i<(dato-1);i++) {
			for (int j=0;j<(dato-1);j++) {
				if (vector[j]>vector[j+1]) { //Si el vecto actual es > al numero siguiente
					aux=vector[j];
					vector[j]=vector[j+1];
					vector[j+1]=aux;
				}
			}
		}
		//Ahora se tiene que imprmer en forma ordenada;
		System.out.print("El menor es --> ");
		for (int i=0;i<dato;i++) {

			System.out.print(vector[i]+" ");
		}
		System.out.print(" <-- El mayor es");
	}
}