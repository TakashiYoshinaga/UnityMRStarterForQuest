// -----------------------------------------------------------------------
// Copyright (c) Takashi Yoshinaga, [現在の年]. 
// All rights reserved.
// -----------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;
using System.IO;

public class MeshCopyScript : MonoBehaviour
{
    [SerializeField]
    GameObject _MeshObject;
    [SerializeField]
    Interactable _Button;
    MeshFilter _MeshFilter;
    MeshCollider _MeshCollider;
    // Start is called before the first frame update
    void Start()
    {
        GameObject meshObject = Instantiate(_MeshObject);
        _MeshFilter = meshObject.GetComponent<MeshFilter>();
        _MeshCollider = meshObject. GetComponent<MeshCollider>();
        _Button.OnClick.AddListener(() => {
            var list=GameObject.FindObjectsOfType<OVRSceneVolumeMeshFilter>();
            for(int i=0;i<list.Length;i++)
            {
                if(i==0)
                {
                    GameObject room=list[i].gameObject;
                    MeshFilter roomMeshFilter=room.GetComponent<MeshFilter>();
                    _MeshFilter.mesh = roomMeshFilter.mesh;
                    _MeshCollider.sharedMesh = roomMeshFilter.mesh;
                    meshObject.transform.rotation=room.transform.rotation;
                    meshObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    _Button.gameObject.SetActive(false);

                    // Save the mesh to a file
                    SaveMeshAsOBJ(_MeshFilter.mesh, "ExportedMesh");
                }
            } 
        });
    }

    void SaveMeshAsOBJ(Mesh mesh, string filenameWithoutExtension)
    {
        string path = Path.Combine(Application.persistentDataPath, filenameWithoutExtension + ".obj");
        StreamWriter writer = new StreamWriter(path);

        writer.WriteLine("# Exported Mesh");
        foreach (Vector3 vertex in mesh.vertices)
        {
            writer.WriteLine("v " + vertex.x + " " + vertex.y + " " + vertex.z);
        }

        writer.WriteLine("# " + mesh.vertices.Length + " vertices");

        foreach (Vector3 normal in mesh.normals)
        {
            writer.WriteLine("vn " + normal.x + " " + normal.y + " " + normal.z);
        }

        writer.WriteLine("# " + mesh.normals.Length + " normals");

        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] triangles = mesh.GetTriangles(i);
            for (int j = 0; j < triangles.Length; j += 3)
            {
                writer.WriteLine("f " + (triangles[j] + 1) + " " + (triangles[j + 1] + 1) + " " + (triangles[j + 2] + 1));
            }
        }

        writer.Close();

        Debug.Log("Mesh saved as OBJ to " + path);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
