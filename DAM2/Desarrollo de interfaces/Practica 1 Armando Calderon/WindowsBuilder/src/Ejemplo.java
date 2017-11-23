import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JRadioButton;
import javax.swing.JCheckBox;
import javax.swing.JSpinner;
import com.toedter.calendar.JCalendar;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import com.toedter.calendar.JDateChooser;
import javax.swing.JPasswordField;

public class Ejemplo {

	private JFrame frame;
	private JTextField txtSoyUnJtexfield;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JPasswordField passwordField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Ejemplo window = new Ejemplo();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Ejemplo() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 350);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblSoyUnLabel = new JLabel("SOY UN LABEL");
		lblSoyUnLabel.setBounds(45, 59, 104, 35);
		frame.getContentPane().add(lblSoyUnLabel);
		
		JButton btnSoyUnButton = new JButton("SOY UN BUTTON");
		btnSoyUnButton.setBounds(214, 55, 130, 39);
		frame.getContentPane().add(btnSoyUnButton);
		
		txtSoyUnJtexfield = new JTextField();
		txtSoyUnJtexfield.setText("SOY UN JTEXFIELD");
		txtSoyUnJtexfield.setBounds(108, 105, 130, 35);
		frame.getContentPane().add(txtSoyUnJtexfield);
		txtSoyUnJtexfield.setColumns(10);
		
				
		JButton btnAceptar = new JButton("ACEPTAR");
		btnAceptar.setBounds(284, 253, 89, 23);
		frame.getContentPane().add(btnAceptar);
		
		JCheckBox chckbxSoyUnJcheckbox = new JCheckBox("SOY UN JCHECKBOX");
		chckbxSoyUnJcheckbox.setBounds(40, 248, 144, 28);
		frame.getContentPane().add(chckbxSoyUnJcheckbox);
		
		JSpinner spinner = new JSpinner();
		spinner.setBounds(330, 162, 29, 20);
		frame.getContentPane().add(spinner);
		
		JRadioButton rdbtnNewRadioButton = new JRadioButton("New radio button");
		buttonGroup.add(rdbtnNewRadioButton);
		rdbtnNewRadioButton.setSelected(true);
		rdbtnNewRadioButton.setBounds(40, 184, 176, 23);
		frame.getContentPane().add(rdbtnNewRadioButton);
		
		JRadioButton rdbtnSoyUnJradiobutton = new JRadioButton("SOY UN JRADIOBUTTON");
		buttonGroup.add(rdbtnSoyUnJradiobutton);
		rdbtnSoyUnJradiobutton.setBounds(40, 210, 155, 35);
		frame.getContentPane().add(rdbtnSoyUnJradiobutton);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"madrid", "jaen", "cocoloco", "juannis"}));
		comboBox.setBounds(331, 204, 28, 20);
		frame.getContentPane().add(comboBox);
		
		JDateChooser dateChooser = new JDateChooser();
		dateChooser.setBounds(45, 28, 95, 20);
		frame.getContentPane().add(dateChooser);
		
		passwordField = new JPasswordField();
		passwordField.setBounds(214, 11, 130, 37);
		frame.getContentPane().add(passwordField);
		
		
		
	}
}
