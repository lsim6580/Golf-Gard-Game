using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Player_Hand : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> CardPlaces = new List<GameObject>();
    public string SelectedPlace { get; set; }
    public bool IsCurrentPlayer { get; set; } = false;
    public bool NeedsACard { get {
            
            return CardPlaces.Exists(x => x.GetComponent<Card_Place>().card == null);
        }
    }
    public bool HasInit { get; set; }
    public 
    void Start()
    {
    }

    public void Init(string playerName)
    {
        if(!HasInit)
        {
            if(CardPlaces.Count == 0)
            {
                HasInit = true;
                foreach (Transform child in transform)
                {
                    CardPlaces.Add(child.gameObject);
                    Debug.Log($"from player hand {child.name}");
                }
            }
        }
    }

    public void PlaceCard(GameObject card)
    {
        var cardPlace = CardPlaces.FirstOrDefault(x=>x.GetComponent<Card_Place>().card == null);
        var script = cardPlace.GetComponent<Card_Place>();
        script.AssignCard(card.name);
        var position = cardPlace.transform.position;
        card.transform.SetPositionAndRotation(position, new Quaternion(0, 0, 0, 0));
        card.transform.Rotate(new Vector3(0, 90, 180));
    }

    public void SetSelectedPlace(string name)
    {
        var oldPlace = GameObject.Find(SelectedPlace);
        if (oldPlace != null)
        {
            var oldScript = oldPlace.GetComponent<Card_Place>();
            oldScript.IsSelected = false;
        }
        var place = GameObject.Find(name);
        var newScript = place.GetComponent<Card_Place>();
        SelectedPlace = name;
        newScript.IsSelected = true;
        Debug.Log(SelectedPlace);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
