using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theVault
{
    public class Impressora
    {
        int nrlinhas, nrpagina = 1;
        public void imprimeGrelha(PrintDocument printDocument1, System.Drawing.Printing.PrintPageEventArgs e, DataGridView grelha)
        {
            Graphics impressora = e.Graphics;
            Font tipoLetra = new Font("Arial", 10);
            Font tipoLetraMaior = new Font("Arial", 12, FontStyle.Bold);
            Brush cor = Brushes.Black;
            float mesquerda, mdireita, msuperior, minferior, linha, largura;
            Pen caneta = new Pen(cor, 2);

            // Margens
            mesquerda = printDocument1.DefaultPageSettings.Margins.Left;
            mdireita = printDocument1.DefaultPageSettings.Bounds.Right - mesquerda;
            msuperior = printDocument1.DefaultPageSettings.Margins.Top;
            minferior = printDocument1.DefaultPageSettings.Bounds.Height - msuperior;
            largura = mdireita - mesquerda;
            // Calcular as colunas da grelha
            float[] colunas = new float[grelha.Columns.Count];
            float lgrelha = 0;
            for (int i = 0; i < grelha.Columns.Count; i++)
                lgrelha += grelha.Columns[i].Width;
            colunas[0] = mesquerda;
            float total = mesquerda, larguraColuna;
            for (int i = 0; i < grelha.Columns.Count - 1; i++)
            {
                larguraColuna = grelha.Columns[i].Width / lgrelha;
                colunas[i + 1] = larguraColuna * largura + total;
                total = colunas[i + 1];
            }
            // Cabeçalhos
            for (int i = 0; i < grelha.Columns.Count; i++)
            {
                impressora.DrawString(grelha.Columns[i].HeaderText, tipoLetraMaior, cor, colunas[i], msuperior);
            }
            linha = msuperior + tipoLetraMaior.Height;
            // Ciclo para percorrer a grelha
            int l;
            for (l = nrlinhas; l < grelha.Rows.Count; l++)
            {
                // Desenhar linha
                impressora.DrawLine(caneta, mesquerda, linha, mdireita, linha);
                // Escrever uma linha
                for (int c = 0; c < grelha.Columns.Count; c++)
                {
                    impressora.DrawString(grelha.Rows[l].Cells[c].Value.ToString(),
                        tipoLetra, cor, colunas[c], linha);
                }
                // Avançar para linha seguinte
                linha = linha + tipoLetra.Height;
                // Verificar se o papel acabou
                if (linha + tipoLetra.Height > minferior)
                    break;
            }
            // Tem mais páginas?
            if (l < grelha.Rows.Count)
            {
                nrlinhas = l + 1;
                e.HasMorePages = true;
            }
            // Rodapé
            impressora.DrawString("Página " + nrpagina.ToString(), tipoLetra, cor, mesquerda, minferior);
            // NR Página
            nrpagina++;
            // Linhas
            // Linha superior
            impressora.DrawLine(caneta, mesquerda, msuperior, mdireita, msuperior);
            // Linha inferior
            impressora.DrawLine(caneta, mesquerda, linha, mdireita, linha);
            // Colunas
            for (int c = 0; c < colunas.Length; c++)
            {
                impressora.DrawLine(caneta, colunas[c], msuperior, colunas[c], linha);
            }
            // Linha lado direito
            impressora.DrawLine(caneta, mdireita, msuperior, mdireita, linha);
        }
    }
}