import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.FlowLayout;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;

public class Calculadora1_FlowLayout {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Calculadora1_FlowLayout window = new Calculadora1_FlowLayout();
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
	public Calculadora1_FlowLayout() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 354, 147);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(new FlowLayout(FlowLayout.CENTER, 5, 5));
		
		JLabel lblNewLabel = new JLabel("Num 1");
		frame.getContentPane().add(lblNewLabel);
		
		textField_1 = new JTextField();
		frame.getContentPane().add(textField_1);
		textField_1.setColumns(10);
		
		JLabel lblNewLabel_1 = new JLabel("  Num 2    ");
		frame.getContentPane().add(lblNewLabel_1);
		
		textField_2 = new JTextField();
		frame.getContentPane().add(textField_2);
		textField_2.setColumns(10);
		
		JButton btnNewButton = new JButton("+");
		frame.getContentPane().add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("*");
		frame.getContentPane().add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("-");
		frame.getContentPane().add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton("/");
		frame.getContentPane().add(btnNewButton_3);
		
		JLabel lblNewLabel_2 = new JLabel("TOTAL");
		frame.getContentPane().add(lblNewLabel_2);
		
		textField = new JTextField();
		frame.getContentPane().add(textField);
		textField.setColumns(10);
	}

}
