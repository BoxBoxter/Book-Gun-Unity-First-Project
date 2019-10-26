using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCreator : MonoBehaviour
{
    public GameObject bookPrefabReference;
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "BookClone" || collision.gameObject.name == "book_0001a") ;
        {
            Destroy(collision.gameObject);
            GameObject newBook = Instantiate(bookPrefabReference);
            //float xOffset = Random.Range(-1, 1);
            //newBook.transform.Translate(new Vector3(xOffset, 0, 0));
        }
            //Instantiate(bookPrefabReference, transform.position, collision.gameObject.transform.rotation);

        }
}
