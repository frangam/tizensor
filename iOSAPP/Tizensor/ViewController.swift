

import UIKit
import CoreBluetooth

struct ServiceTypes: OptionSet {
  let rawValue: Int
  
  static let none           = ServiceTypes([])
  static let pedometer      = ServiceTypes(rawValue: 1 << 0)
  static let accelerometer  = ServiceTypes(rawValue: 1 << 1)
  static let gyroscope      = ServiceTypes(rawValue: 1 << 2)
  static let heartrate      = ServiceTypes(rawValue: 1 << 3)
  static let gravity        = ServiceTypes(rawValue: 1 << 4)
  static let linearacc      = ServiceTypes(rawValue: 1 << 5)
  static let light          = ServiceTypes(rawValue: 1 << 6)
  static let hrgreen        = ServiceTypes(rawValue: 1 << 7)
  static let pressure       = ServiceTypes(rawValue: 1 << 8)
  static let location       = ServiceTypes(rawValue: 1 << 9)

  static let allSensors:ServiceTypes = [.pedometer, .accelerometer, .gyroscope, .heartrate, .linearacc, .gravity, .light, .hrgreen, .pressure, .location]
}

public protocol BLEDelegate {
  func bleDidUpdateState()
  func bleDidConnectToPeripheral()
  func bleDidDisconenctFromPeripheral()
  func bleDidReceiveData(data: Data?)
}

protocol BLEPeripheralProtocol {
  func BlueToothStatus(peripheral: CBPeripheralManager)
}

//let gearS3_1 = "D4C1D198-3F08-D07F-B847-8959621BA00D"

let extControlSensorsForUsingCharacteristicCBUUID = CBUUID(string: "7627BF64-FB2F-415A-BBE7-9D403343BADF")
let accelerometerServiceCBUUID = CBUUID(string: "CDD441F7-A574-4370-AF7B-2811FA832D0A")
let accelerometerCharacteristicCBUUID = CBUUID(string: "74CF6286-3C85-4BB8-AB94-0A6DEE08F260")
let gyroscopeServiceCBUUID = CBUUID(string: "1FB9B584-5072-4E3D-8635-5EA8C8A72270")
let gyroscopeCharacteristicCBUUID = CBUUID(string: "1A3D0B34-DAC0-479C-91AF-FCB75F0B15B9")
let heartRateServiceCBUUID = CBUUID(string: "6DFBAD02-708B-4B07-A72B-9EDC9EFA7B70")
let heartRateCharacteristicCBUUID = CBUUID(string: "3FCB96E6-E293-47A8-8238-0FCCCBA129A2")
let linearAccelerationServiceCBUUID = CBUUID(string: "8688C2AA-0905-4D23-B636-92688B269169")
let linearAccelerationCharacteristicCBUUID = CBUUID(string: "D108B7F6-4A6A-4F83-BCC2-8C807D3C1510")
let gravityServiceCBUUID = CBUUID(string: "AB2561CD-D15E-42C7-8C9C-2E98206B2661")
let gravityCharacteristicCBUUID = CBUUID(string: "506A9FE2-2391-4330-979B-1CA27DF9DD89")
let lightServiceCBUUID = CBUUID(string: "2DD84D72-B634-443D-9219-6E986CD5FB97")
let lightCharacteristicCBUUID = CBUUID(string: "7DF8639A-D846-4518-828A-B8F06F35EAB5")
let pressureServiceCBUUID = CBUUID(string: "149B37E9-1EC4-4F43-BF85-AF749225A4C7")
let pressureCharacteristicCBUUID = CBUUID(string: "096D0E1C-3CBD-427A-871E-A1FCB9EB044E")
let pedometerServiceCBUUID = CBUUID(string: "2253FB3D-17F3-4B5F-B35B-8B2D46028A6E")
let pedometerCharacteristicCBUUID = CBUUID(string: "5FED9024-6645-4662-A96B-18185270651A")
let hrGreenLightServiceCBUUID = CBUUID(string: "9F61335F-1368-47E5-A6CF-D81CABBA8809")
let hrGreenLightCharacteristicCBUUID = CBUUID(string: "F6361764-5612-40BD-8E81-9A4D6859CBB7")
let stressServiceCBUUID = CBUUID(string: "0E32347F-59AA-4642-864F-25EF781801D1")
let stressCharacteristicCBUUID = CBUUID(string: "A91065A8-4B70-4A26-9653-F6E58328A28E")
let locationServiceCBUUID = CBUUID(string: "783A3CF3-B865-4103-B8A1-CF88A440C5C9")
let locationCharacteristicCBUUID = CBUUID(string: "727A501F-17DF-47A6-A9E3-008000711F0D")
let sleepServiceCBUUID = CBUUID(string: "91EE0AD3-B464-41C0-A827-88C388CB5920")
let sleepCharacteristicCBUUID = CBUUID(string: "11F15CA4-8DE4-4C9E-8E1A-1D7EC9E36B00")
let extControlServiceCBUUID = CBUUID(string: "785147F1-CB21-4C3A-B2BC-D4B2CA0FCE27")
let bleCharacteriscticRecordSensorDataCBUUID = CBUUID(string: "4B1B530C-1540-4917-B100-3AF4BE67F8A0")
let bleCharacteriscticStartSensorDataCBUUID = CBUUID(string: "96E40C7C-11FE-4FBE-99F9-D2B961324EC8")
let bleCharacteriscticStopSensorDataCBUUID = CBUUID(string: "D7BB0470-EA3F-4868-891B-43993E121534")
let bleCharacteriscticDeleteSensorDataCBUUID = CBUUID(string: "928557A2-1C9B-412F-B675-3A572EA1A183")
let bleCharacteriscticRecordTimeMarkSensorDataCBUUID = CBUUID(string: "5E50C0BE-09FD-4049-82DC-6DC3AA4EEAF5")
let bleCharacteriscticSendToCloudSensorDataCBUUID = CBUUID(string: "C085302D-5B76-4A9B-B784-BA6D9417FD4F")
let bleCharacteriscticConnectedCBUUID = CBUUID(string: "5A541D0A-36DF-43AF-9343-3B935C4B8025")
let bleCharacteriscticDataDeletedCBUUID = CBUUID(string: "5A76C9DB-914B-4364-B3DB-3F892756AC17")
let bleCharacteriscticRecordedTimeMarkCBUUID = CBUUID(string: "594BD17F-AA3A-4AF6-8587-219DCEF3223F")


let extControlStartServiceCBUUID = CBUUID(string: "BD2BD840-1BB2-4115-8D8C-62AC2945626B")
let extControlStartCharacteristicCBUUID = CBUUID(string: "96E40C7C-11FE-4FBE-99F9-D2B961324EC8")
let extControlStopServiceCBUUID = CBUUID(string: "4C4979B3-C54B-45A1-972D-3920E70178D8")
let extControlStopCharacteristicCBUUID = CBUUID(string: "D7BB0470-EA3F-4868-891B-43993E121534")
let extControlDeleteServiceCBUUID = CBUUID(string: "A870FE06-527C-4659-8259-E67E36AC44E2")
let extControlDeleteCharacteristicCBUUID = CBUUID(string: "928557A2-1C9B-412F-B675-3A572EA1A183")
let extControlRecordTimeMarkServiceCBUUID = CBUUID(string: "E853DFDA-6B2E-40F2-97A6-3E00A143C3D2")
let extControlRecordTimeMarkCharacteristicCBUUID = CBUUID(string: "5E50C0BE-09FD-4049-82DC-6DC3AA4EEAF5")
let extControlPostHTTPerviceCBUUID = CBUUID(string: "B8CBB5CF-B86E-4DFC-BDCD-249B62C69DBB")
let extControlPostHTTPCharacteristicCBUUID = CBUUID(string: "C085302D-5B76-4A9B-B784-BA6D9417FD4F")

let readCharacteristicsRate = 0.1

let extControlIsConnected    = "0"
let extControlStart          = "1"
let extControlStop           = "2"
let extControlDelete         = "3"
let extControlRecordTimeMark = "4"
let extControlHTTPPOST       = "5"




let serviceIds: [CBUUID] = [accelerometerServiceCBUUID, gyroscopeServiceCBUUID, heartRateServiceCBUUID, linearAccelerationServiceCBUUID, gravityServiceCBUUID, lightServiceCBUUID, pressureServiceCBUUID, pedometerServiceCBUUID, hrGreenLightServiceCBUUID, stressServiceCBUUID, locationServiceCBUUID, extControlStartServiceCBUUID, extControlStopServiceCBUUID, extControlDeleteServiceCBUUID, extControlRecordTimeMarkServiceCBUUID, extControlPostHTTPerviceCBUUID] //, locationServiceCBUUID, sleepServiceCBUUID]
let characteristicsIds: [CBUUID] = [accelerometerCharacteristicCBUUID, gyroscopeCharacteristicCBUUID, heartRateCharacteristicCBUUID, linearAccelerationCharacteristicCBUUID, gravityCharacteristicCBUUID, lightCharacteristicCBUUID, pressureCharacteristicCBUUID, pedometerCharacteristicCBUUID, hrGreenLightCharacteristicCBUUID, stressCharacteristicCBUUID, locationCharacteristicCBUUID, extControlStartCharacteristicCBUUID, extControlStopCharacteristicCBUUID, extControlDeleteCharacteristicCBUUID, extControlRecordTimeMarkCharacteristicCBUUID, extControlPostHTTPCharacteristicCBUUID] //, locationCharacteristicCBUUID, sleepServiceCBUUID]

let accelerometerServiceID =      "es.ugr.tizensor.accelerometer"; // Index 0
let gyroscopeServiceID =          "es.ugr.tizensor.gyroscope"; // Index 1
let heartRateServiceID =          "es.ugr.tizensor.heartrate"; // Index 2
let linearAccelerationServiceID = "es.ugr.tizensor.linearacceleration" // Index 3
let gravityServiceID =            "es.ugr.tizensor.gravity"        // Index 4
let lightServiceID =              "es.ugr.tizensor.light"        // Index 5
let pressureServiceID =           "es.ugr.tizensor.pressure"      // Index 6
let pedometerServiceID =          "es.ugr.tizensor.pedometer"      // Index 7
let hrGreenLightServiceID =       "es.ugr.tizensor.hrgreenlight"    // Index 8
let stressServiceID =             "es.ugr.tizensor.stress"        // Index 9
let locationServiceID =           "es.ugr.tizensor.location"      // Index 10
let sleepServiceID =              "es.ugr.tizensor.sleep"        // Index 11

let timemarkID =                  "es.ugr.tizensor.timemark"

class ViewController: UIViewController {

  var localPeripheralManager: CBPeripheralManager! = nil
  var localService:CBService? = nil
  var localPeripheral:CBPeripheral? = nil
  var createdService:CBService? = nil
  var peripheralDiscoverableName = "TIZENSOR" //The name of perfipheral name
  var timeMarkCounter = 0
  var powerOn = false
  // timer used to retry to scan for peripheral, when we don't find it
  var rescanTimer: Timer?
  
  public var delegate:  BLEPeripheralProtocol?
  
  private var centralManager: CBCentralManager!
  private var heartRatePeripheral: CBPeripheral!
  private var activePeripheral: CBPeripheral?
  private(set) var peripherals     = [CBPeripheral]()
  private var characteristics = [String : CBCharacteristic]()
  private var collectDataTimer: Timer!
  
  private var extControlStartCharacteristic: CBMutableCharacteristic!
  private var extControlStopCharacteristic: CBMutableCharacteristic!
  private var extControlRecordTimeMarkCharacteristic: CBMutableCharacteristic!
  private var extControlDeleteCharacteristic: CBMutableCharacteristic!
  private var extControlSendToCloudCharacteristic: CBMutableCharacteristic!
  private var extControlConnectedCharacteristic: CBMutableCharacteristic!
  private var extControlDeletedDataCharacteristic: CBMutableCharacteristic!
  private var extControlRecordedTimeMarkCharacteristic: CBMutableCharacteristic!
  private var extControlSensorsForUsingCharacteristic: CBMutableCharacteristic!
  
  @IBOutlet weak var lbMarcaTiempo: UILabel!
  @IBOutlet weak var btnDelete: UIButton!
  @IBOutlet weak var lbState: UILabel!
  @IBOutlet weak var heartRateLabel: UILabel!
  @IBOutlet weak var greenHRLabel: UILabel!
  @IBOutlet weak var lightLabel: UILabel!
  @IBOutlet weak var pressureLabel: UILabel!
  @IBOutlet weak var stepsLabel: UILabel!
  @IBOutlet weak var velocityLabel: UILabel!
  @IBOutlet weak var accelerometerLabel: UILabel!
  @IBOutlet weak var gyroscopeLabel: UILabel!
  @IBOutlet weak var gravityLabel: UILabel!
  @IBOutlet weak var linearAccelerationLabel: UILabel!
  @IBOutlet weak var btnDeleteWatchData: UIButton!
  @IBOutlet weak var newTimeEventLabel: UILabel!
  @IBOutlet weak var generalStateLabel: UILabel!
  @IBOutlet weak var btnStart: UIButton!
  @IBOutlet weak var btnStop: UIButton!
    @IBOutlet weak var locationLabel: UILabel!
  @IBOutlet weak var stressLabel: UILabel!
  
  @IBOutlet weak var btnMarcaTiempo: UIButton!
  @IBOutlet weak var btnSendDataToServer: UIButton!
  @IBAction func btnSendDataToServer(_ sender: UIButton) {
    changeCharacteriscticValue(value: extControlHTTPPOST)
  }
  
  
  @IBAction func btnRefresh(_ sender: UIBarButtonItem) {
    changeCharacteriscticValue(value: extControlIsConnected)
  }
  
  @IBAction func btnDelete(_ sender: UIButton) {
    deleteAllFiles()
    resetLabelsValues()
  }
  
  
  @IBAction func btnStart(_ sender: UIButton) {
    //Peripheral Approach
    if(localPeripheralManager.state == .poweredOn){
      timeMarkCounter = 0;
      deleteAllFiles()
      resetLabelsValues()
      newTimeEventLabel.text = "Recording TimeMark of Start Recording"
      generalStateLabel.text = "Recording Data..."
      btnMarcaTiempo.isHidden = false
      lbMarcaTiempo.isHidden = false
      btnDelete.isHidden = true
      btnDeleteWatchData.isHidden = true
      btnSendDataToServer.isHidden = true
      
      changeCharacteriscticValue(value: String(ServiceTypes.allSensors.rawValue))
      
//      let desiredSensors:ServiceTypes = [.accelerometer, .gyroscope]
//      changeCharacteriscticValue(value: String(desiredSensors.rawValue))

    }
    
    
    
    
    //Central Approach
//    if(centralManager.state == .poweredOn){
//      deleteAllFiles()
//
//      newTimeEventLabel.text = "Evento Inicio de prueba registrado"
//      generalStateLabel.text = "Capturando datos..."
//      //avisar al watch que empiece a recopilar datos
//      writeCharacteristicValue(uuid: extControlStartCharacteristicCBUUID, value: extControlRecordTimeMark)
//
//
//      collectDataTimer = Timer.scheduledTimer(timeInterval: readCharacteristicsRate, target: self, selector: #selector(readAllCharacteristicValues), userInfo: nil, repeats: true)
//
//      btnInit.isHidden = true
//      btnDisconnect.isHidden = true
//      btnConnect.isHidden = true
//      btnStart.isHidden = true
//      btnStop.isHidden = false
//      btnDelete.isHidden = true
//      btnDeleteWatchData.isHidden = true
//    }
  }

  
  
  @IBAction func btnStop(_ sender: UIButton) {
    
    //Peripheral Approach
    if(localPeripheralManager.state == .poweredOn){
      changeCharacteriscticValue(value: extControlStop)
      
      generalStateLabel.text = "Stopped"
      //btnStart.isHidden = false
      //btnStop.isHidden = true
      btnDelete.isHidden = true
      btnDeleteWatchData.isHidden = false
      btnSendDataToServer.isHidden = false
      btnMarcaTiempo.isHidden = true
      lbMarcaTiempo.isHidden = true
      lbMarcaTiempo.text = "---"
    }
    //Central Approach
//    if(centralManager.state == .poweredOn){
//      collectDataTimer.invalidate()
//      generalStateLabel.text = "Stopped"
//      btnInit.isHidden = false
//      btnDisconnect.isHidden = false
//      btnConnect.isHidden = true
//      btnStart.isHidden = true
//      btnStop.isHidden = true
//      btnDelete.isHidden = false
//      btnDeleteWatchData.isHidden = false
//      writeCharacteristicValue(uuid: extControlStopCharacteristicCBUUID, value: extControlStop)
//    }
  }
  
  @IBAction func btnRegisterNewTimeEvent(_ sender: UIButton) {
    if(localPeripheralManager.state == .poweredOn){
      changeCharacteriscticValue(value: extControlRecordTimeMark)
      newTimeEventLabel.text = "Recording new label (time mark)..." //TODO
//    writeCharacteristicValue(uuid: extControlRecordTimeMarkCharacteristicCBUUID, value: extControlRecordTimeMark)
    }
  }
  
  @IBAction func btnDeleteWatchData(_ sender: UIButton) {
    if(localPeripheralManager.state == .poweredOn){
      changeCharacteriscticValue(value: extControlDelete)
//    writeCharacteristicValue(uuid: extControlDeleteCharacteristicCBUUID, value: extControlDelete)
      generalStateLabel.text = "Deleting data..."
    }
  }
  
  
  @objc private func scanTimeout() {
    print("[DEBUG] Scanning stopped")
    self.centralManager.stopScan()
  }
  
  public func startScanning(timeout: Double) -> Bool {
    if self.centralManager.state != .poweredOn {
      print("[ERROR] Couldn´t start scanning")
      return false
    }
    
    print("[DEBUG] Scanning started")
    // CBCentralManagerScanOptionAllowDuplicatesKey
//    Timer.scheduledTimer(timeInterval: timeout, target: self, selector: #selector(scanTimeout), userInfo: nil, repeats: false)
    
//    let services:[CBUUID] = [CBUUID(string: "3570AC09-CAE2-4EBC-80E6-6D92A9830785")]
//    self.centralManager.scanForPeripherals(withServices: services, options: nil)
    self.centralManager.scanForPeripherals(withServices: nil, options: nil)
    
    return true
  }
  
  public func connectToPeripheral(peripheral: CBPeripheral) -> Bool {
    
    if self.centralManager.state != .poweredOn {
      print("[ERROR] Couldn´t connect to peripheral")
      return false
    }
    
    print("[DEBUG] Connecting to peripheral: \(peripheral.identifier.uuidString)")
    
    self.centralManager.connect(peripheral, options: [CBConnectPeripheralOptionNotifyOnDisconnectionKey : NSNumber(value: true)])
    
    return true
  }
  
  public func disconnectFromPeripheral(peripheral: CBPeripheral) -> Bool {
    
    if self.centralManager.state != .poweredOn {
      print("[ERROR] Couldn´t disconnect from peripheral")
      return false
    }
    
    self.centralManager.cancelPeripheralConnection(peripheral)
    
    return true
  }
  
  @objc func readAllCharacteristicValues(){
    for characteristic in self.characteristics.values{
      if characteristic.properties.contains(.read) {
//        print("characteristic \(characteristic.uuid): properties contains .read")
        self.activePeripheral!.readValue(for: characteristic)
      }
//      if characteristic.properties.contains(.notify) {
//        print("characteristic \(characteristic.uuid): properties contains .notify")
//        self.activePeripheral!(true, for: characteristic)
//      }
    }
  }
  
  public func read(uuid:String) {
    
    guard let char = self.characteristics[uuid] else { return }
    print("reading characteristic: \(uuid)")
    self.activePeripheral?.readValue(for: char)
  }
  
  public func write(uuid:String, data: Data) {
    
    guard let char = self.characteristics[uuid] else { return }
    
    self.activePeripheral?.writeValue(data, for: char, type: .withoutResponse)
  }

    
  override func viewDidLoad() {
    super.viewDidLoad()
    resetLabelsValues()
//    btnInit.isHidden = true
//    btnDisconnect.isHidden = true
//    btnConnect.isHidden = false
    btnMarcaTiempo.isHidden = true
    btnStart.isHidden = false
    btnStop.isHidden = false
    btnDelete.isHidden = true
    btnDeleteWatchData.isHidden = true
    btnSendDataToServer.isHidden = true
//    centralManager = CBCentralManager(delegate: self, queue: nil)
    localPeripheralManager = CBPeripheralManager(delegate: self, queue: nil, options: nil)
    startServices()
    
    // Make the digits monospaces (avoid shifting when the numbers change)
//    heartRateLabel.font = UIFont.monospacedDigitSystemFont(ofSize: heartRateLabel.font!.pointSize, weight: .regular)
  }
  
  func stopServices() {
    print("Stopping BLE services...")
    self.localPeripheralManager.removeAllServices()
    self.localPeripheralManager.stopAdvertising()
  }
  
  func startServices() {
    print("starting services")
//    print("Service UUID: " + accelerometerServiceCBUUID.uuidString)
//    print("Characteristic: read UUID: \(accelerometerCharacteristicCBUUID.uuidString)")
//    print("Characteristic: write UUID: \(BLEWrite)")



    
    // Create the service, add the characteristic to it and push the service to the peripheral
    let acceleromenterService = CBMutableService(type: accelerometerServiceCBUUID, primary: true)
    acceleromenterService.characteristics = [CBMutableCharacteristic(type: accelerometerCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(acceleromenterService)
    
    let gyroscopeService = CBMutableService(type: gyroscopeServiceCBUUID, primary: true)
    gyroscopeService.characteristics = [CBMutableCharacteristic(type: gyroscopeCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(gyroscopeService)
    
    let heartRateService = CBMutableService(type: heartRateServiceCBUUID, primary: true)
    heartRateService.characteristics = [CBMutableCharacteristic(type: heartRateCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(heartRateService)
    
    let linearAccelerationService = CBMutableService(type: linearAccelerationServiceCBUUID, primary: true)
    linearAccelerationService.characteristics = [CBMutableCharacteristic(type: linearAccelerationCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(linearAccelerationService)
    
    let gravityService = CBMutableService(type: gravityServiceCBUUID, primary: true)
    gravityService.characteristics = [CBMutableCharacteristic(type: gravityCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(gravityService)
    
    let lightService = CBMutableService(type: lightServiceCBUUID, primary: true)
    lightService.characteristics = [CBMutableCharacteristic(type: lightCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(lightService)
    
    let pressureService = CBMutableService(type: pressureServiceCBUUID, primary: true)
    pressureService.characteristics = [CBMutableCharacteristic(type: pressureCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(pressureService)
    
    let pedometerService = CBMutableService(type: pedometerServiceCBUUID, primary: true)
    pedometerService.characteristics = [CBMutableCharacteristic(type: pedometerCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(pedometerService)
    
    let hrGreenLightService = CBMutableService(type: hrGreenLightServiceCBUUID, primary: true)
    hrGreenLightService.characteristics = [CBMutableCharacteristic(type: hrGreenLightCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(hrGreenLightService)
    
    let stressService = CBMutableService(type: stressServiceCBUUID, primary: true)
    stressService.characteristics = [CBMutableCharacteristic(type: stressCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(stressService)
    
    let locationService = CBMutableService(type: locationServiceCBUUID, primary: true)
    locationService.characteristics = [CBMutableCharacteristic(type: locationCharacteristicCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])]
    localPeripheralManager.add(locationService)
    
    extControlSensorsForUsingCharacteristic = CBMutableCharacteristic(type: extControlSensorsForUsingCharacteristicCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlStartCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticStartSensorDataCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlStopCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticStopSensorDataCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlDeleteCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticDeleteSensorDataCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlSendToCloudCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticSendToCloudSensorDataCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlRecordTimeMarkCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticRecordTimeMarkSensorDataCBUUID, properties: [.notify, .read], value: nil, permissions: [.readable])
    extControlConnectedCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticConnectedCBUUID, properties: [.notify, .read, .write, .writeWithoutResponse], value: nil, permissions: [.readable, .writeable])
    extControlDeletedDataCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticDataDeletedCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])
    extControlRecordedTimeMarkCharacteristic = CBMutableCharacteristic(type: bleCharacteriscticRecordedTimeMarkCBUUID, properties: [.write, .writeWithoutResponse], value: nil, permissions: [.writeable])
    
    let externalControlService = CBMutableService(type: extControlServiceCBUUID, primary: true)
    externalControlService.characteristics = [extControlStartCharacteristic, extControlStopCharacteristic, extControlDeleteCharacteristic, extControlSendToCloudCharacteristic, extControlRecordTimeMarkCharacteristic, extControlConnectedCharacteristic, extControlDeletedDataCharacteristic, extControlRecordedTimeMarkCharacteristic, extControlSensorsForUsingCharacteristic]
    localPeripheralManager.add(externalControlService)
    
    // Create an advertisement, using the services UUIDs
    let advertisement: [String : Any] = [CBAdvertisementDataLocalNameKey: self.peripheralDiscoverableName,
                                         //CBAdvertisementDataManufacturerDataKey : manufacturerData,
      CBAdvertisementDataServiceUUIDsKey : [accelerometerServiceCBUUID, gyroscopeServiceCBUUID, heartRateServiceCBUUID, linearAccelerationServiceCBUUID, gravityServiceCBUUID, lightServiceCBUUID, pedometerServiceCBUUID, pressureServiceCBUUID, stressServiceCBUUID,locationServiceCBUUID, hrGreenLightServiceCBUUID, extControlServiceCBUUID]]
    self.localPeripheralManager.startAdvertising(advertisement)
    
//    extControlServiceCBUUID
//    createdService = service
//    print(localPeripheralManager)
  }
  
  func changeCharacteriscticValue(value: String){
    var characteristic:CBMutableCharacteristic
    
    switch value {
    case extControlIsConnected:
      characteristic = extControlConnectedCharacteristic
    case extControlStart:
      characteristic = extControlStartCharacteristic
    case extControlStop:
      characteristic = extControlStopCharacteristic
    case extControlDelete:
      characteristic = extControlDeleteCharacteristic
    case extControlRecordTimeMark:
      characteristic = extControlRecordTimeMarkCharacteristic
    case extControlHTTPPOST:
      characteristic = extControlSendToCloudCharacteristic
    default:
      characteristic = extControlStartCharacteristic
    }
    
    localPeripheralManager.updateValue(value.data(using: String.Encoding(rawValue: String.Encoding.utf8.rawValue))!, for: characteristic, onSubscribedCentrals: nil)
  }
  

  func onAccelerometerReceived(_ value: String) {
    accelerometerLabel.text = String(value)
  }
  func onGyroscopeReceived(_ value: String) {
    gyroscopeLabel.text = String(value)
  }
  func onHeartRateReceived(_ value: String) {
    heartRateLabel.text = String(value)
  }
  func onLinearAccelerationReceived(_ value: String) {
    linearAccelerationLabel.text = String(value)
  }
  func onGravityReceived(_ value: String) {
    gravityLabel.text = String(value)
  }
  func onLightReceived(_ value: String) {
    lightLabel.text = String(value)
  }
  func onPressureReceived(_ value: String) {
    pressureLabel.text = String(value)
  }
  func onPedometerReceived(_ value: String) {
    if(value != ""){
      let arr = value.split(separator: ",")
      stepsLabel.text = String(arr.count > 0 ? arr[0] : "00") //number of steps
      velocityLabel.text = String(arr.count > 5 ? arr[5] : "00") //last speed (Km/h)
    }
  }
  func onStressReceived(_ value: String) {
    stressLabel.text = String(value)
  }
  func onLocationReceived(_ value: String) {
    locationLabel.text = String(value)
  }
  func onHRGreenLightreceived(_ value: String) {
    greenHRLabel.text = String(value)
  }
  func onConnected(_ value: String) {
    resetLabelsValues()
    //lbState.text = String(value)
    //self.btnStart.isHidden = false
    lbState.text = "Connected!!" //+String(value)
  }
  func onDeleted(_ value: String) {
    generalStateLabel.text = String(value)
  }
  func onRecordedTimeMark(_ value: String) {
    let arr = value.split(separator: ",")
    let eventVal:String = ""+String(arr[1])
    print("Event: " + eventVal)
    
    newTimeEventLabel.text = "Event: " + eventVal
    let eventName = getEventName(item: String(timeMarkCounter))
    
    print("My Event: " + eventName)
    newTimeEventLabel.text = eventName + ": "+eventVal
  }
  
  func getEventName(item: String)-> String{
    var res:String
    print("My Label: " + item)
    if (item == "1"){res = "1-Sitting"}
    else if (item == "2"){res = "2-Standing"}
    else if (item == "3"){res = "3-Walking"}
    else if (item == "4"){res = "4-Jogging"}
    else if (item == "5"){res = "5-Jumping"}
    else{res = item}
    return res
  }
}

extension ViewController: CBPeripheralManagerDelegate {
  func peripheralManagerDidUpdateState(_ peripheral: CBPeripheralManager)
  {
    if (peripheral.state == .poweredOn) {
      // Bluetooth peripheral is on, will start the services
      print("peripheral is on")
      //      self.powerOn = true
      self.startServices()
    }
    else {
      // Bluetooth peripheral is off, sto all services
      print("peripheral is off")
      self.lbState.text = "Bluetooth inactive. Enable!!"
      //      self.powerOn = false
      self.stopServices()
    }
    
    // Call delegate for parent (viewController ???)
    //Tools.sendNotification(name: "BlueToothStatusUpdate", objectName: "peripheral", object: peripheral)
    
    // Send the status to delegate subscribed
    if delegate != nil {
      delegate?.BlueToothStatus(peripheral: peripheral)
    }
  }
  
  func peripheralManager(_ peripheral: CBPeripheralManager,
                         didAdd service: CBService,
                         error: Error?){
    
    if error != nil {
      print(("Error adding services: \(error?.localizedDescription)"))
    }
    else {
      print("service added to peripheral")
      
      // Save service locally, used later to advertise
      localService = service
      
      //let identifier = Bundle.main.bundleIdentifier!
      //aelog("Bundle Identifier: " + Tools.toString(identifier))
      //let manufacturerData = identifier.data( using: String.Encoding.utf8, allowLossyConversion: false)
      //            let advertisement: [String : Any] = CBAdvertisementDataManufacturerDataKey : manufacturerData,
      //                CBAdvertisementDataServiceUUIDsKey : [service.uuid]]
      
      print(peripheralDiscoverableName)
//      // Create an advertisement, using the service UUID
//      let advertisement: [String : Any] = [CBAdvertisementDataLocalNameKey: self.peripheralDiscoverableName,
//                                           //CBAdvertisementDataManufacturerDataKey : manufacturerData,
//        CBAdvertisementDataServiceUUIDsKey : [service.uuid]]
//      // start the advertisement
//      self.localPeripheralManager.startAdvertising(advertisement)
      
      print("Starting to advertise.")
    }
  }
  
  
  // Advertising done
  //
  func peripheralManagerDidStartAdvertising(_ peripheral: CBPeripheralManager,
                                            error: Error?){
    if error != nil {
      print(("Error while advertising: \(error?.localizedDescription)"))
    }
    else {
      print("adversiting done. no error")
    }
    //peripheral.stopAdvertising()
  }
  
  
  
  // called when CBCentral manager request to read
  //
  func peripheralManager(_ peripheral: CBPeripheralManager,
                         didReceiveRead request: CBATTRequest) {
    
    print("didReceiveRead...")
    print(request)
    
    if request.characteristic.service!.uuid.isEqual(extControlServiceCBUUID) && request.characteristic.uuid.isEqual(bleCharacteriscticStartSensorDataCBUUID)
    {
//        // Set the correspondent characteristic's value
//        // to the request
//        request.value = characteristic.value

        // Respond to the request
        localPeripheralManager.respond(
            to: request,
            withResult: .success)
    }
    //peripheral.respond(to: request, withResult: CBATTError.success)
  }
  
  
  // called when central manager write value to peripheral manager
  // a popup appear before that, asking to pair device : "jumelage avec ..."
  //
  public func peripheralManager(_ peripheral: CBPeripheralManager, didReceiveWrite requests: [CBATTRequest]) {
//    print("didReceiveWrite requests")
//    guard
//      let characteristicCBUUID: CBUUID = bleCharacteriscticRecordSensorDataCBUUID,
//      let request: CBATTRequest = requests.filter({ $0.characteristic.uuid == characteristicCBUUID }).first,
//      let value: Data = request.value
//      else { return }
//    // Send response to central if this writing request asks for response [.withResponse]
//    print("Sending response: Success")
//    self.localPeripheralManager?.respond(to: request, withResult: .success)
//    print("Match characteristic for writing")
//    do {
//      if let receivedData: [String : String] = try PropertyListSerialization.propertyList(from: value, options: [], format: nil) as? [String: String] {
//        print("Written value is: \(receivedData)")
////        self.delegate?.didReceiveData()
//      } else {
//        return
//      }
//    } catch let error {
//      print(error)
//    }
    
        if requests.count > 0 {
//          if requests[0].characteristic.uuid.isEqual(linearAccelerationCharacteristicCBUUID)
//          print("received data")
          
          let uuid:CBUUID = requests[0].characteristic.uuid
          let dataReceived:String = String(decoding: requests[0].value!, as: UTF8.self)
          
          if(uuid != bleCharacteriscticDataDeletedCBUUID && uuid != bleCharacteriscticConnectedCBUUID){
            let tizenID = getTizenServiceIdFromCharacteristicId(characteristicUUID: uuid)
            print("\(tizenID): \(dataReceived)")
            
            updateCharacteristicValueLabel(uuid: uuid, value: getCharacteristicValue(uuid: uuid, value: dataReceived))
            
            if(timeMarkCounter > 0){
              saveCharacteristicValue(uuid: uuid, value: dataReceived)
            }
          }
          else{
            updateCharacteristicValueLabel(uuid: uuid, value: getCharacteristicValue(uuid: uuid, value: dataReceived))
          }
        }
    
    
//    print("value sent by central Manager: \(value)")


//    print("value sent by central Manager: " + String(data: value, encoding: String.Encoding.utf8)!)

//    let str = NSString(data:value, encoding:String.Encoding.utf8.rawValue)!
//    print("value sent by central Manager : " + String(describing: str))
    
//    if requests.count > 0 {
//      let str = NSString(data: requests[0].value!, encoding:String.Encoding.utf8.rawValue)!
//      print("value sent by central Manager : " + String(describing: str))
//    }
  }
  
  func respond(to request: CBATTRequest, withResult result: CBATTError.Code) {
    print("respnse requested")
  }
  
  
  
  
  //    func peripheralManager(_ peripheral: CBPeripheralManager, didReceiveRead request: CBATTRequest)
  //    {
  //        if request.characteristic.UUID.isEqual(characteristic.UUID)
  //        {
  //            // Set the correspondent characteristic's value
  //            // to the request
  //            request.value = characteristic.value
  //
  //            // Respond to the request
  //            peripheralManager.respondToRequest(
  //                request,
  //                withResult: .Success)
  //        }
  //    }
  
  
  
  //        // Every xxx second : if no peripheral == peripheralSearchedName is found, retry to scan
  //        rescanTimer = Timer.scheduledTimer(timeInterval: 3.0, target: self,
  //                                           selector: #selector(BLEPeripheralManager.refreshAdvertising), userInfo: nil, repeats: true)
  
  //    // will refresh : To be defined
  //    func refreshAdvertising() {
  //        DispatchQueue.main.async {
  //            if self.localService != nil && self.powerOn {
  //                //Logs.info(message: "Advertise as: " + self.peripheralDiscoverableName)
  //                //let advertisement: [String : Any] = [self.peripheralDiscoverableName : BLEGenericService]
  //
  //                //self.localPeripheralManager.startAdvertising(advertisement)
  //            }
  //
  //        }
  //    }

  
}



extension ViewController: CBPeripheralDelegate {
  func peripheral(_ peripheral: CBPeripheral, didDiscoverServices error: Error?) {
    print("discovering services. Total: \(peripheral.services!.count)")
//    guard let services = peripheral.services else { return }
//    for service in services {
//      print(service)
////      peripheral.discoverCharacteristics(, for: <#T##CBService#>)
//      peripheral.discoverCharacteristics(nil, for: service)
//    }
    
    if error != nil {
      print("[ERROR] Error discovering services. \(error!)")
      return
    }
    
    lbState.text = "\(self.activePeripheral?.name ?? "") Servicios: \(peripheral.services!.count )"
    
    if(peripheral.services!.count > 0){
      print("[DEBUG] Found services for peripheral: \(peripheral.identifier.uuidString)")
    }
    
    for service in peripheral.services! {
      peripheral.discoverCharacteristics(characteristicsIds, for: service)
    }
  }
  
  func peripheral(_ peripheral: CBPeripheral, didModifyServices invalidatedServices: [CBService]) {
    print("Peripheral services changed...")
//    resetLabelsValues()
    self.activePeripheral?.discoverServices(nil)
  }

  func peripheral(_ peripheral: CBPeripheral, didDiscoverCharacteristicsFor service: CBService, error: Error?) {
    if error != nil {
      print("[ERROR] Error discovering characteristics. \(error!)")
      return
    }
    
//    print("[DEBUG] Found characteristics for peripheral: \(peripheral.identifier.uuidString)")
    
    print("discovering characteristics. Total: \(service.characteristics!.count)")
    guard let characteristics = service.characteristics else { return }

    for characteristic in characteristics {
      self.characteristics[characteristic.uuid.uuidString] = characteristic
      print(characteristic)

//      if characteristic.properties.contains(.read) {
//        print("characteristic \(characteristic.uuid): properties contains .read")
//        peripheral.readValue(for: characteristic)
//      }
//      if characteristic.properties.contains(.notify) {
//        print("characteristic \(characteristic.uuid): properties contains .notify")
//        peripheral.setNotifyValue(true, for: characteristic)
//      }
//      if characteristic.properties.contains(.write) {
//        print("characteristic \(characteristic.uuid): properties contains .write")
//      let mydata: Data = "record_time".data(using: .utf8)!
//        print("My data: \(mydata). String: \(String(decoding: mydata, as: UTF8.self))")
//        peripheral.writeValue(mydata, for: characteristic, type: .withoutResponse)
//      }
    }
//    enableNotifications(enable: true)
  }

//  func peripheral(_ peripheral: CBPeripheral, didUpdateValueFor characteristic: CBCharacteristic, error: Error?) {
//    var characteristicRawValue = "";
//    var characteristicSimpleValue = "";
//
//    if error != nil {
//      print("[ERROR] Error updating value in characteristic \(characteristic.uuid.uuidString) \(error!)")
//      return
//    }
//
//    print("[DEBUG] updating value for characteristic \(characteristic.uuid)")
//    characteristicRawValue = getCharacteristicRawValue(from: characteristic)
//    saveCharacteristicValue(uuid: characteristic.uuid, value: characteristicRawValue)
//    characteristicSimpleValue = getCharacteristicValue(uuid: characteristic.uuid, value: characteristicRawValue)
//    updateCharacteristicValueLabel(uuid: characteristic.uuid, value: characteristicSimpleValue)
//  }
  
  func updateCharacteristicValueLabel(uuid: CBUUID, value: String){
    switch uuid {
    case accelerometerCharacteristicCBUUID:
      onAccelerometerReceived(value)
    case gyroscopeCharacteristicCBUUID:
      onGyroscopeReceived(value)
    case heartRateCharacteristicCBUUID:
     onHeartRateReceived(value)
    case linearAccelerationCharacteristicCBUUID:
      onLinearAccelerationReceived(value)
    case gravityCharacteristicCBUUID:
     onGravityReceived(value)
    case lightCharacteristicCBUUID:
      onLightReceived(value)
    case pressureCharacteristicCBUUID:
      onPressureReceived(value)
    case pedometerCharacteristicCBUUID:
      onPedometerReceived(value)
    case hrGreenLightCharacteristicCBUUID:
      onHRGreenLightreceived(value)
    case locationCharacteristicCBUUID:
      onLocationReceived(value)
    case stressCharacteristicCBUUID:
      onStressReceived(value)
    case bleCharacteriscticConnectedCBUUID:
      onConnected(value)
    case bleCharacteriscticDataDeletedCBUUID:
      onDeleted(value)
    case bleCharacteriscticRecordedTimeMarkCBUUID:
      timeMarkCounter += 1
      onRecordedTimeMark(value)
//    case stressCharacteristicCBUUID:
//      onStressReceived(value)
//    case locationCharacteristicCBUUID:
//      onLocationReceived(value)
//    case sleepCharacteristicCBUUID:
//      onSleepReceived(value)
    default:
      onAccelerometerReceived(value)
    }
  }

  
//  func writeCharacteristicValue(uuid: CBUUID, value: String){
//    if(self.characteristics.count > 0 && self.characteristics[uuid.uuidString] != nil){
//      let mydata = value.data(using: String.Encoding(rawValue: String.Encoding.utf8.rawValue))!
//        print("My data: \(mydata). String: \(String(decoding: mydata, as: UTF8.self))")
//        self.activePeripheral?.writeValue(mydata, for: self.characteristics[uuid.uuidString]!, type: .withoutResponse)
//    }
//  }
  
  func getCharacteristicRawValue(from characteristic: CBCharacteristic)-> String {
    guard let characteristicData = characteristic.value else { return ""}
    let res = String(data: characteristicData, encoding: String.Encoding.utf8)!
//    print("getCharacteristicRawValue: \(characteristicData). String: \(res)")
    return res
  }

  func getCharacteristicValue(uuid: CBUUID, value: String)-> String {
    let messageArr = value.split(separator: ",")
    var result = ""
    
    if(value != ""){
      switch uuid {
      case heartRateCharacteristicCBUUID, hrGreenLightCharacteristicCBUUID, lightCharacteristicCBUUID, pressureCharacteristicCBUUID, stressCharacteristicCBUUID:
        result = String(messageArr[3])
      case pedometerCharacteristicCBUUID:
        result = String("\(messageArr[3]),\(messageArr[4]),\(messageArr[5]),\(messageArr[6]),\(messageArr[7]),\(messageArr[7]),\(messageArr[8]),\(messageArr[9]),\(messageArr[10])")
      case locationCharacteristicCBUUID:
        result = String("\(messageArr[3]), \(messageArr[4]), \(messageArr[5])")
      case bleCharacteriscticDataDeletedCBUUID, bleCharacteriscticConnectedCBUUID, bleCharacteriscticRecordedTimeMarkCBUUID:
        result = value
      default:
        result = String("\(messageArr[3]), \(messageArr[4]), \(messageArr[5])")
      }
    }
    
//    print("getCharacteristicValue: \(result)")
    
    return result
  }
  
  func saveCharacteristicValue(uuid: CBUUID, value: String) {
    let dir = FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first!
    let fileURL = dir.appendingPathComponent("\(getTizenServiceIdFromCharacteristicId(characteristicUUID: uuid)).csv")
    
    do{
      if(!FileManager.default.fileExists(atPath: fileURL.path)){
        print("creando file: \(fileURL.path)")
        FileManager.default.createFile(atPath: fileURL.path, contents: nil, attributes: nil)
      }
      
      let fileUpdater = try FileHandle(forUpdating: fileURL)
      fileUpdater.seekToEndOfFile()
      fileUpdater.write(value.data(using: .utf8)!)
      fileUpdater.closeFile()
    }
    catch{
      print("Error: \(error)")
    }
  }
  
  func deleteFile(filename: String){
    let filemanager = FileManager()
    let dir = FileManager.default.urls(for: .documentDirectory, in: .userDomainMask).first!
    let fileURL = dir.appendingPathComponent(filename)
    
    do{
      if(FileManager.default.fileExists(atPath: fileURL.path)){
        try filemanager.removeItem(at: fileURL)
      }
    }catch{
      print("Error deleting file: \(error)")
    }
  }
  
  func deleteAllFiles(){
    deleteFile(filename: "\(accelerometerServiceID).csv")
    deleteFile(filename: "\(gyroscopeServiceID).csv")
    deleteFile(filename: "\(heartRateServiceID).csv")
    deleteFile(filename: "\(linearAccelerationServiceID).csv")
    deleteFile(filename: "\(gravityServiceID).csv")
    deleteFile(filename: "\(lightServiceID).csv")
    deleteFile(filename: "\(pressureServiceID).csv")
    deleteFile(filename: "\(pedometerServiceID).csv")
    deleteFile(filename: "\(hrGreenLightServiceID).csv")
    deleteFile(filename: "\(stressServiceID).csv")
    deleteFile(filename: "\(locationServiceID).csv")
    deleteFile(filename: "\(timemarkID).csv")
//    deleteFile(filename: "\(sleepServiceID).csv")
    btnDelete.isHidden = true
  }
  
  func getTizenServiceIdFromCharacteristicId(characteristicUUID: CBUUID) -> String {
    var result = ""
    
    switch characteristicUUID {
    case accelerometerCharacteristicCBUUID:
      result = accelerometerServiceID
    case gyroscopeCharacteristicCBUUID:
      result = gyroscopeServiceID
    case heartRateCharacteristicCBUUID:
      result = heartRateServiceID
    case linearAccelerationCharacteristicCBUUID:
      result = linearAccelerationServiceID
    case gravityCharacteristicCBUUID:
      result = gravityServiceID
    case lightCharacteristicCBUUID:
      result = lightServiceID
    case pressureCharacteristicCBUUID:
      result = pressureServiceID
    case pedometerCharacteristicCBUUID:
      result = pedometerServiceID
    case hrGreenLightCharacteristicCBUUID:
      result = hrGreenLightServiceID
    case stressCharacteristicCBUUID:
      result = stressServiceID
    case locationCharacteristicCBUUID:
      result = locationServiceID
    case sleepCharacteristicCBUUID:
      result = sleepServiceID
    case bleCharacteriscticRecordedTimeMarkCBUUID:
      result = timemarkID
    default:
      result = accelerometerServiceID
    }
    
    return result
  }
  
  func resetLabelsValues() {
    accelerometerLabel.text = "0.0000000, 0.0000000, 0.0000000"
    gyroscopeLabel.text = "0.0000000, 0.0000000, 0.0000000"
    gravityLabel.text = "0.0000000, 0.0000000, 0.0000000"
    linearAccelerationLabel.text = "0.0000000, 0.0000000, 0.0000000"
    heartRateLabel.text = "000"
    greenHRLabel.text = "000"
    lightLabel.text = "000"
    pressureLabel.text = "000"
    stepsLabel.text = "000"
    velocityLabel.text = "000"
    stressLabel.text = "000"
    locationLabel.text = "0.0000000, 0.0000000, 0.0000000"
    newTimeEventLabel.text = "---"
    generalStateLabel.text = "---"
    timeMarkCounter = 0
  }
}
