package TransicionInterfaces;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class InterfazB {
	

	private JFrame frmInterfazB;

	/**
	 * Launch the application.
	 */

	/**
	 * Create the application.
	 */
	public InterfazB() {
		initialize();
		frmInterfazB.setVisible(true);
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmInterfazB = new JFrame();
		frmInterfazB.setTitle("INTERFAZ B");
		frmInterfazB.setBounds(100, 100, 450, 300);
		frmInterfazB.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmInterfazB.getContentPane().setLayout(null);
		
		JButton button = new JButton("IR A A");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				//Abrir Interfaz A
				InterfazA a = new InterfazA();
				a.getFrmInterfazA().setVisible(true);
				
				// Cerrar interfaz B
				frmInterfazB.dispose();
			}
		});
		button.setBounds(81, 82, 276, 87);
		frmInterfazB.getContentPane().add(button);
	}

}
