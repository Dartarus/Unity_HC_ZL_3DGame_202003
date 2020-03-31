
using UnityEngine;

public class PraticeMember: MonoBehaviour
{
    public SpriteRenderer logo;

    public Transform cam;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = false;
        logo.flipX = true;
        print("去小數點:" + Mathf.Floor(1.23456f));

        cam.Rotate(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
