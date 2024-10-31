using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{   
    public int id;
    public string nome;
    public int custo;
    public string descricao;
    public Sprite imagemCarta;

    public TextMeshPro TextoNome;
    public TextMeshPro TextoDescricao;

    private MeshRenderer imagemRenderer;
   

    public void Start(){
        imagemRenderer = transform.Find("imagemCarta").GetComponent<MeshRenderer>();
        
        // Atualizar os atributos ao iniciar
        AtualizarTexto();
        AtualizarImagem();
    }
    // Este método pode ser usado para definir os atributos da carta quando ela é criada
    public void InicializarCarta(int id,string nome, int custo, string descricao, Sprite imagem)
    {
        this.id = id;
        this.nome = nome;
        this.custo = custo;
        this.descricao = descricao;
        imagemCarta = imagem;

        AtualizarTexto();
        AtualizarImagem();
    }

    void AtualizarTexto()
    {
        TextoNome.SetText(nome);
        TextoDescricao.SetText(descricao);
        
    }

    void AtualizarImagem()
    {
        if (imagemCarta != null && imagemRenderer != null)
        {
            // Cria um novo material com o sprite da imagem
            Material material = new Material(Shader.Find("Unlit/Texture"));
            material.mainTexture = imagemCarta.texture;
            imagemRenderer.material = material;
        }
    }


}
