package TransicionInterfaces;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.BorderLayout;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class InterfazA {

	private JFrame frmInterfazA;

	protected JFrame getFrmInterfazA() {
		return frmInterfazA;
	}

	protected void setFrmInterfazA(JFrame frmInterfazA) {
		this.frmInterfazA = frmInterfazA;
	}

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					InterfazA window = new InterfazA();
					window.frmInterfazA.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public InterfazA() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmInterfazA = new JFrame();
		frmInterfazA.setTitle("INTERFAZ A");
		frmInterfazA.setBounds(100, 100, 450, 300);
		frmInterfazA.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmInterfazA.getContentPane().setLayout(null);
		
		JButton btnIrAB = new JButton("IR A B");
		
		btnIrAB.setBounds(72, 69, 276, 87);
		frmInterfazA.getContentPane().add(btnIrAB);
		
		
		// EVENTO BOTON IR A B.
		btnIrAB.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				//ABRIR INTERFAZ B
				InterfazB b = new InterfazB();
				
				//CERRAR interfaz A
				frmInterfazA.dispose();
			}
		});
	}
}
