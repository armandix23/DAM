import java.awt.Component;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.Font;

import javax.swing.AbstractButton;
import javax.swing.ImageIcon;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JTextPane;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

public class Traduccion {

	private static final Component TextPaneIngles = null;
	private JFrame frmTraduccionDePalabras;
	private JTextField textPaneIngles;
	private JTextField textPaneFrances;
	private JTextField textIngles;
	private JTextField textFrances;
	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Traduccion window = new Traduccion();
					window.frmTraduccionDePalabras.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Traduccion() {
		initialize();

		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmTraduccionDePalabras = new JFrame();
		frmTraduccionDePalabras.setTitle("Traduccion de palabras");
		frmTraduccionDePalabras.setBounds(100, 100, 550, 382);
		frmTraduccionDePalabras.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmTraduccionDePalabras.getContentPane().setLayout(null);
		
		
		
		JButton btnExit = new JButton("EXIT");
		
		btnExit.setFont(new Font("Yu Gothic Medium", Font.BOLD, 16));
		btnExit.setBounds(233, 281, 80, 51);
		frmTraduccionDePalabras.getContentPane().add(btnExit);
		
		JButton btnIngles = new JButton("INGLES");
		
		btnIngles.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String Palabra = textIngles.getText();
				URL webIngles = null;
				InputStream contenido = null;
				String pagWeb = "";
				String constante = "<td class='ToWrd' >";
				int auxiliar = 0;
				
				try {
					
					webIngles = new URL("http://www.wordreference.com/es/en/translation.asp?spen="+ Palabra);
					
				} catch (MalformedURLException ingles) {
					// TODO Auto-generated catch block
					ingles.printStackTrace();
				}
				
			
				try {
					contenido = webIngles.openStream();
					
				} catch (IOException ingles) {
					// TODO Auto-generated catch block
					ingles.printStackTrace();
				}
				
				
				// Convertir InputStream en String
				pagWeb = getStringFromInputStream(contenido);
				
				pagWeb = pagWeb.substring(pagWeb.indexOf(constante)+constante.length());
				while(pagWeb.charAt(auxiliar) != '<')
					auxiliar++;
				pagWeb= pagWeb.substring(0, auxiliar - 1);
				textIngles.setText("");
				textPaneIngles.setText(pagWeb);
				
			}
			
			// convert InputStream to String
				private String getStringFromInputStream(InputStream is) {

					BufferedReader br = null;
					StringBuilder sb = new StringBuilder();

					String line;
					try {

						br = new BufferedReader(new InputStreamReader(is));
						while ((line = br.readLine()) != null) {
							sb.append(line);
						}

					} catch (IOException e) {
						e.printStackTrace();
					} finally {
						if (br != null) {
							try {
								br.close();
							} catch (IOException e) {
								e.printStackTrace();
							}
						}
					}

					return sb.toString();

				}

		
			
			
			
		});
		btnIngles.setFont(new Font("Yu Gothic Medium", Font.PLAIN, 30));
		btnIngles.setBounds(64, 36, 176, 36);
		frmTraduccionDePalabras.getContentPane().add(btnIngles);
		
		JButton btnFrances = new JButton("FRANC\u00C9S");
		btnFrances.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String Palabra = textFrances.getText();
				URL webFrances = null;
				InputStream contenido = null;
				String pagWeb = "";
				String constante = "<td class='ToWrd' >";
				int auxiliar = 0;
				
				try {
					
					webFrances = new URL("http://www.wordreference.com/esfr/"+ Palabra);
					
				} catch (MalformedURLException frances) {
					// TODO Auto-generated catch block
					frances.printStackTrace();
				}
				
			
				try {
					contenido = webFrances.openStream();
					
				} catch (IOException frances) {
					// TODO Auto-generated catch block
					frances.printStackTrace();
				}
				
				
				// Convertir InputStream en String
				pagWeb = getStringFromInputStream(contenido);
				
				pagWeb = pagWeb.substring(pagWeb.indexOf(constante)+constante.length());
				while(pagWeb.charAt(auxiliar) != '<')
					auxiliar++;
				pagWeb= pagWeb.substring(0, auxiliar - 1);
				textFrances.setText("");
				textPaneFrances.setText(pagWeb);
				
			}
			
			// convert InputStream to String
				private String getStringFromInputStream(InputStream is) {

					BufferedReader br = null;
					StringBuilder sb = new StringBuilder();

					String line;
					try {

						br = new BufferedReader(new InputStreamReader(is));
						while ((line = br.readLine()) != null) {
							sb.append(line);
						}

					} catch (IOException e) {
						e.printStackTrace();
					} finally {
						if (br != null) {
							try {
								br.close();
							} catch (IOException e) {
								e.printStackTrace();
							}
						}
					}

					return sb.toString();

				}
			
		});
		btnFrances.setFont(new Font("Yu Gothic Medium", Font.PLAIN, 30));
		btnFrances.setBounds(307, 36, 176, 36);
		frmTraduccionDePalabras.getContentPane().add(btnFrances);
		
		textPaneIngles = new JTextField();
		textPaneIngles.setEditable(false);
		textPaneIngles.setText("");
		textPaneIngles.setBounds(64, 148, 176, 120);
		frmTraduccionDePalabras.getContentPane().add(textPaneIngles);
		textPaneIngles.setColumns(10);
		
		textPaneFrances = new JTextField();
		textPaneFrances.setEditable(false);
		textPaneFrances.setText("");
		textPaneFrances.setColumns(10);
		textPaneFrances.setBounds(307, 150, 176, 120);
		frmTraduccionDePalabras.getContentPane().add(textPaneFrances);
		
		JLabel lblNewingleLabel = new JLabel("Espa\u00F1ol/Ingl\u00E9s");
		lblNewingleLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblNewingleLabel.setBounds(97, 81, 128, 25);
		frmTraduccionDePalabras.getContentPane().add(lblNewingleLabel);
		
		JLabel lblEspaolfrancs = new JLabel("Espa\u00F1ol/Franc\u00E9s");
		lblEspaolfrancs.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblEspaolfrancs.setBounds(341, 83, 128, 25);
		frmTraduccionDePalabras.getContentPane().add(lblEspaolfrancs);
		
		textIngles = new JTextField();
		textIngles.setBounds(64, 104, 176, 36);
		frmTraduccionDePalabras.getContentPane().add(textIngles);
		textIngles.setColumns(10);
		
		textFrances = new JTextField();
		textFrances.setColumns(10);
		textFrances.setBounds(307, 104, 176, 36);
		frmTraduccionDePalabras.getContentPane().add(textFrances);
		
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "Saliendo del traductor..", "EXIT",JOptionPane.INFORMATION_MESSAGE);
				frmTraduccionDePalabras.dispose();
				Login pagina = new Login();
				Login.main(null);
			}

			private void dispose() {
				// TODO Auto-generated method stub
				
			}
		});
	}
}
