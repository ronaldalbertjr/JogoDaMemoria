using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CandidatosInfoScript : MonoBehaviour 
{
    public Canvas menu;
    public Text cand;
    public string candidato;
	public void OnHighlightCardEnter()
    {
        switch(candidato)
        {
            case "Freixo":
                cand.text = "Marcelo Ribeiro Freixo (Niterói, 12 de abril de 1967) se notabilizou pelo trabalho à frente da CPI das Milícias na Alerj, que indiciou 225 pessoas. Sua atuação acabou também lhe rendendo inúmeras ameaças de morte, o que faz com tenha, há anos, a escolta de seguranças armados.";
                break;
            case "Jandira": 
                cand.text = "Jandira Feghali (Curitiba, PR, 17 de maio de 1957) é uma médica, política e sindicalista brasileira, integrante do Partido Comunista do Brasil (PCdoB). Construiu sua carreira política pelo estado do Rio de Janeiro.";
                break;
            case "Cyro":
                cand.text = "Cyro Garcia (Manhumirim, 26 de outubro de 1954) é um ex-bancário, militante socialista e político brasileiro. É membro do PSTU desde a sua fundação, em 1994.";
                break;
            case "Flavio":
                cand.text = "Flávio Nantes Bolsonaro (Resende, 30 de abril de 1981) é um Empresário, Advogado e político brasileiro, filiado ao PSC. possuindo especializações em Políticas Públicas pelo IUPERJ e em Empreendedorismo pela FGV. É filho do deputado federal Jair Bolsonaro.";
                break;
            case "Crivela":
                cand.text = "Marcelo Bezerra Crivella (Rio de Janeiro, 9 de outubro de 1957) é um político, cantor gospel, engenheiro, escritor e bispo brasileiro. Exerce mandato de senador da República pelo Partido Republicano Brasileiro, representando o estado do Rio de Janeiro.";
                break;
            case "Molon":
                cand.text = "Alessandro Lucciola Molon (Belo Horizonte, 28 de outubro de 1971) é um político, professor e radialista brasileiro filiado à Rede Sustentabilidade. Em seu primeiro mandato como deputado federal, destacou-se por ter sido relator e principal articulador da aprovação do Marco Civil da Internet.";
                break;
            case "Thelma":
                cand.text = "Thelma Bastos é candidata a prefeita do Rio de Janeiro pelo PCO (Partido Da Causa Operária)";
                break;
            case "PedroPaulo":
                cand.text = "Pedro Paulo bate em mulher.";
                break;
            case "Carmen":
                cand.text = "Carmen Migules é a candidata pelo recém aprovado Partido Novo. Seu vice será Tomas Pelosi";
                break;
            case "Indio":
                cand.text = "Antonio Pedro Índio da Costa (Rio de Janeiro, 20 de outubro de 1970) é empresário, advogado e político brasileiro fundador do Partido Social Democrático (PSD).";
                break;
            case "Osorio":
                cand.text = "Carlos Roberto de Figueiredo Osorio (Rio de Janeiro, 20 de outubro de 1965) é um empresário, e político brasileiro, atualmente deputado estadual do Rio de Janeiro";
                break;
        }
    }
}
