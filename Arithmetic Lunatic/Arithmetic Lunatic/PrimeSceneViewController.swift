//
//  PrimeSceneViewController.swift
//  Arithmetic Lunatic
//
//  Created by Mike Xu on 12/11/18.
//  Copyright © 2018 Mike Xu. All rights reserved.
//

import UIKit

class PrimeSceneViewController: UIViewController {

    @IBOutlet weak var TheFirstNumberText: UITextField!
    @IBOutlet weak var TheSign: UITextField!
    @IBOutlet weak var TheSecondNumberText: UITextField!
    @IBOutlet weak var TheAnswer: UITextField!
    @IBOutlet weak var TheScoreText: UITextField!
    @IBOutlet weak var TheTimingText: UITextField!
    
    var TheSupposedAnswer = 0
    
    var timer: Timer!
    var theTimeLeft = 80
    
    func Refresh() //Getting a new problem, refreshing information in this scene, these kind of stuff.
    {
        let ANewProblem = Problems()
        TheFirstNumberText.text = String(ANewProblem.TheFirstNumber)
        TheSecondNumberText.text = String(ANewProblem.TheSecondNumber)
        TheSign.text = ANewProblem.TheSign
        TheSupposedAnswer = ANewProblem.TheSupposedAnswer
        
        TheAnswer.text = ""
    }

    func YouGotItRight()
    {
        var previousScore:Int = Int(TheScoreText.text!)!
        previousScore += 10
        TheScoreText.text = String(previousScore)
    }
    
    func YouGotItWrong()
    {
        var previousScore:Int = Int(TheScoreText.text!)!
        previousScore -= 5
        TheScoreText.text = String(previousScore)
    }

    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        let ANewProblem = Problems()
        
        TheFirstNumberText.text = String(ANewProblem.TheFirstNumber)
        TheSecondNumberText.text = String(ANewProblem.TheSecondNumber)
        TheSign.text = ANewProblem.TheSign
        TheSupposedAnswer = ANewProblem.TheSupposedAnswer
        
        
        //Set the timer
        //Will come back
        //Have come back
        timer = Timer.scheduledTimer(timeInterval: 1, target: self, selector: #selector(PrimeSceneViewController.Countdown), userInfo: nil, repeats: true)
        
        PrintTheTimeLeft()

    }
    
    
    @IBAction func Submitting(_ sender: Any) {
        if (Int(TheAnswer.text!) == TheSupposedAnswer)
        {
            YouGotItRight()
        }
        else
        {
            YouGotItWrong()
        }
        
        self.Refresh()

    }
    
    
    //Timing function:
    @objc func Countdown ()
    {
        //TheTimingText.text = String(Int(TheTimingText.text!)! - 1)
        self.theTimeLeft -= 1
        PrintTheTimeLeft()
        
        if (self.theTimeLeft <= 0)
        {
            //TheTimingText.text = "-10000"
            
            performSegue(withIdentifier: "Time's up!", sender: self)
            
            timer.invalidate()
        }
        
    }
    
    func PrintTheTimeLeft ()
    {
        var secondsLeft = self.theTimeLeft
        var minutesLeft = 0
        while (secondsLeft >= 60)
        {
            secondsLeft -= 60
            minutesLeft += 1
        }

        let timingText = String(minutesLeft) + ":" + String(secondsLeft)
        TheTimingText.text = timingText
        //print(timingText)
        
    }
    
    
    //Attempting to pass the score value
    override func prepare(for segue: UIStoryboardSegue, sender: Any?)
    {
        if segue.destination is FinalScoreSceneViewController
        {
            let AFinalSceneObject = segue.destination as? FinalScoreSceneViewController
            AFinalSceneObject?.finalScore = Int(TheScoreText.text!)!
        }
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


class Problems
{
    var TheFirstNumber = 1
    var TheSecondNumber = 1
    var TheSign = "+"
    var TheSupposedAnswer = 1
    
    func Checking (theFirstNumber: Int, theSecondNumber: Int, theNumberOfTheSign: Int) -> Bool
    {
        if ((theNumberOfTheSign == 1) && (theFirstNumber < theSecondNumber))
        {
            return false //Which means that this case won't work.
        }
        else
        {
            return true //Which means that this case work.
        }
    }
    
    init()
    {
        var tempForTheSign = 0
        repeat
        {
            
            self.TheFirstNumber = Int(arc4random_uniform(10))
            self.TheSecondNumber = Int(arc4random_uniform(10))
            tempForTheSign = Int(arc4random_uniform(3))
        } while (!Checking(theFirstNumber: self.TheFirstNumber, theSecondNumber: self.TheSecondNumber, theNumberOfTheSign: tempForTheSign))
        
        
        
        switch tempForTheSign
        {
        case 0:
            self.TheSign = "+"
            TheSupposedAnswer = TheFirstNumber + TheSecondNumber
            break
        case 1:
            self.TheSign = "-"
            TheSupposedAnswer = TheFirstNumber - TheSecondNumber
            break
        case 2:
            self.TheSign = "*"
            TheSupposedAnswer = TheFirstNumber * TheSecondNumber
            break
        default:
            break
            //impossible
            
        }
    }
}
