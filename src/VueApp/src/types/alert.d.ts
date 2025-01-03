

declare enum AlertType {
  INFO = 'info',
  SUCCESS = 'success',
  WARNING = 'warning',
  ERROR = 'error'
}

interface Alert {
  message: string
  type: AlertType
  durration?: number
}
