using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRepository
{
    private static ItemRepository repository = null;

    ItemRepository GetRepository(){
        if(repository == null){
            repository = new ItemRepository();
        }

        return repository;
    }

    ItemRepository(){
        
    }

}