import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;


import java.awt.Font;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JPasswordField;
import javax.swing.JSeparator;

public class Login {

	private JFrame frmRegistro;
	private JTextField userUsuario;
	private JPasswordField txtContraseña;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Login window = new Login();
					window.frmRegistro.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Login() {
		initialize();
		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmRegistro = new JFrame();
		frmRegistro.setTitle("Login");
		frmRegistro.setBounds(100, 100, 450, 300);
		frmRegistro.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmRegistro.getContentPane().setLayout(null);
		
		JLabel lblUsuario = new JLabel("Usuario *");
		lblUsuario.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblUsuario.setBounds(32, 25, 115, 37);
		frmRegistro.getContentPane().add(lblUsuario);
		
		userUsuario = new JTextField();
		userUsuario.setBounds(214, 25, 165, 47);
		frmRegistro.getContentPane().add(userUsuario);
		userUsuario.setColumns(10);
		
		JLabel lblContraseña = new JLabel("Contrase\u00F1a *");
		lblContraseña.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblContraseña.setBounds(32, 98, 149, 36);
		frmRegistro.getContentPane().add(lblContraseña);
		
		JButton btnEntrar = new JButton("ENTRAR");
		
		btnEntrar.setFont(new Font("Yu Gothic Medium", Font.BOLD, 16));
		btnEntrar.setBounds(32, 194, 159, 37);
		frmRegistro.getContentPane().add(btnEntrar);
		
		JButton btnRegistrarse = new JButton("REGISTRARSE");
		
		btnRegistrarse.setFont(new Font("Yu Gothic Medium", Font.BOLD, 16));
		btnRegistrarse.setBounds(220, 194, 159, 37);
		frmRegistro.getContentPane().add(btnRegistrarse);
		
		txtContraseña = new JPasswordField();
		txtContraseña.setBounds(213, 98, 166, 47);
		frmRegistro.getContentPane().add(txtContraseña);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(10, 181, 376, 2);
		frmRegistro.getContentPane().add(separator);
		
		
		btnEntrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				String usuario = userUsuario.getText();
				char[] input = txtContraseña.getPassword();
				String pass = new String(input);
				
				if( !userUsuario.getText().toString().isEmpty() && !txtContraseña.getText().toString().isEmpty()) {
					
					if(usuario.equals(pass)) {
						JOptionPane.showMessageDialog(null, "Registrado", "ACEPTADO",JOptionPane.INFORMATION_MESSAGE);
						frmRegistro.dispose();
						Traduccion pagina = new Traduccion();
						Traduccion.main(null);
					
					}
					
				}
				if(!usuario.equals(pass)) {
					JOptionPane.showMessageDialog(null, "Campos erroneos", "ERROR", JOptionPane.ERROR_MESSAGE);
					if(!usuario.equals("") & !pass.equals(""))
						JOptionPane.showMessageDialog(null, "Campos erroneos", "ERROR", JOptionPane.ERROR_MESSAGE);
				}
				
			}
		});
		
		
		btnRegistrarse.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				frmRegistro.dispose();
				Registro pagina1 = new Registro();
				pagina1.main(null);
			}
		});
	}
	
	
	

	protected void dispose() {
		// TODO Auto-generated method stub
		
	}
}
