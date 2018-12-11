//
//  FinalScoreSceneViewController.swift
//  Arithmetic Lunatic
//
//  Created by Mike Xu on 12/11/18.
//  Copyright © 2018 Mike Xu. All rights reserved.
//

import UIKit

class FinalScoreSceneViewController: UIViewController {

    var finalScore = 0
    
    @IBOutlet weak var TheFinalScoreText: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        
        TheFinalScoreText.text = String(finalScore)
    }
    

    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */

}
