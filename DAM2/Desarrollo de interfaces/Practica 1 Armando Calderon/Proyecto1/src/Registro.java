import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import com.toedter.calendar.JYearChooser;
import javax.swing.JTextArea;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JScrollPane;
import javax.swing.JCheckBox;
import javax.swing.ButtonGroup;
import javax.swing.JSeparator;

public class Registro {

	private JFrame frmRegistroDeUsuario;
	private JTextField textUsuario;
	private JPasswordField passwordField;
	private JTextField textField_1;
	private JTextField textField_2;
	private final ButtonGroup buttonGroup = new ButtonGroup();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Registro window = new Registro();
					window.frmRegistroDeUsuario.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Registro() {
		initialize();
		// if (textField.getText().toString().isEmpty());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmRegistroDeUsuario = new JFrame();
		frmRegistroDeUsuario.setTitle("Registro de usuario");
		frmRegistroDeUsuario.setBounds(100, 100, 597, 408);
		frmRegistroDeUsuario.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmRegistroDeUsuario.getContentPane().setLayout(null);
		
		JButton btnCancelar = new JButton("CANCELAR");
		
		btnCancelar.setFont(new Font("Yu Gothic Medium", Font.PLAIN, 30));
		btnCancelar.setBounds(310, 279, 233, 61);
		frmRegistroDeUsuario.getContentPane().add(btnCancelar);
		
		JButton button_1 = new JButton("REGISTRARSE");
		
		button_1.setFont(new Font("Yu Gothic Medium", Font.PLAIN, 30));
		button_1.setBounds(41, 279, 245, 61);
		frmRegistroDeUsuario.getContentPane().add(button_1);
		
		JLabel lblUsuario = new JLabel("Usuario *");
		lblUsuario.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblUsuario.setBounds(10, 24, 110, 37);
		frmRegistroDeUsuario.getContentPane().add(lblUsuario);
		
		textUsuario = new JTextField();
		textUsuario.setColumns(10);
		textUsuario.setBounds(130, 14, 134, 47);
		frmRegistroDeUsuario.getContentPane().add(textUsuario);
		
		JLabel label_1 = new JLabel("Contrase\u00F1a");
		label_1.setFont(new Font("SimSun", Font.PLAIN, 24));
		label_1.setBounds(276, 24, 134, 36);
		frmRegistroDeUsuario.getContentPane().add(label_1);
		
		passwordField = new JPasswordField();
		passwordField.setBounds(405, 14, 166, 47);
		frmRegistroDeUsuario.getContentPane().add(passwordField);
		
		JLabel lblCorreo = new JLabel("Correo");
		lblCorreo.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblCorreo.setBounds(21, 94, 86, 37);
		frmRegistroDeUsuario.getContentPane().add(lblCorreo);
		
		JLabel lblZip = new JLabel("ZIP");
		lblZip.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblZip.setBounds(310, 94, 86, 37);
		frmRegistroDeUsuario.getContentPane().add(lblZip);
		
		textField_1 = new JTextField();
		textField_1.setColumns(10);
		textField_1.setBounds(361, 84, 134, 47);
		frmRegistroDeUsuario.getContentPane().add(textField_1);
		
		textField_2 = new JTextField();
		textField_2.setColumns(10);
		textField_2.setBounds(117, 84, 169, 47);
		frmRegistroDeUsuario.getContentPane().add(textField_2);
		
		JLabel lblAoNacimiento = new JLabel("A\u00F1o Nacimiento");
		lblAoNacimiento.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblAoNacimiento.setBounds(21, 165, 175, 37);
		frmRegistroDeUsuario.getContentPane().add(lblAoNacimiento);
		
		JYearChooser yearChooser = new JYearChooser();
		yearChooser.setBounds(204, 175, 47, 20);
		frmRegistroDeUsuario.getContentPane().add(yearChooser);
		
		JLabel lblPais = new JLabel("Pais");
		lblPais.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblPais.setBounds(289, 165, 86, 37);
		frmRegistroDeUsuario.getContentPane().add(lblPais);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(361, 165, 110, 37);
		frmRegistroDeUsuario.getContentPane().add(scrollPane);
		
		JComboBox comboBox = new JComboBox();
		scrollPane.setViewportView(comboBox);
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"ESPA\u00D1A", "NORUEGA", "ESLOVENIA", "SANTO DOMINGO SAVIO", "KAZAJISTAN"}));
		
		JLabel lblDeseaRecibirSpam = new JLabel("Desea recibir SPAM");
		lblDeseaRecibirSpam.setFont(new Font("SimSun", Font.PLAIN, 24));
		lblDeseaRecibirSpam.setBounds(21, 213, 239, 37);
		frmRegistroDeUsuario.getContentPane().add(lblDeseaRecibirSpam);
		
		JCheckBox chckbxNewCheckBox = new JCheckBox("Si");
		buttonGroup.add(chckbxNewCheckBox);
		chckbxNewCheckBox.setSelected(true);
		chckbxNewCheckBox.setBounds(251, 225, 47, 23);
		frmRegistroDeUsuario.getContentPane().add(chckbxNewCheckBox);
		
		JCheckBox chckbxNewCheckBox_1 = new JCheckBox("No");
		buttonGroup.add(chckbxNewCheckBox_1);
		chckbxNewCheckBox_1.setBounds(299, 225, 66, 23);
		frmRegistroDeUsuario.getContentPane().add(chckbxNewCheckBox_1);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(31, 261, 523, 2);
		frmRegistroDeUsuario.getContentPane().add(separator);
		
		button_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				if(textUsuario.getText().length() == 0) {
					JOptionPane.showMessageDialog(null, "Rellene el campo usuario", "ERROR",JOptionPane.ERROR_MESSAGE);
				}else {
					JOptionPane.showMessageDialog(null, "Registrado", "ACEPTADO",JOptionPane.INFORMATION_MESSAGE);
					frmRegistroDeUsuario.dispose();
					Login pagina1 = new Login();
					Login.main(null);
				}
			}
			

			
		});
		
		btnCancelar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				frmRegistroDeUsuario.dispose();
				Login pagina = new Login();
				Login.main(null);
			}

			private void dispose() {
				// TODO Auto-generated method stub
				
			}
		});
		
	}

	
}
